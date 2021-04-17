using AutoMapper;
using ITMCollegeService.Contracts;
using ITMCollegeService.DTO;
using ITMCollegeService.Identity;
using ITMCollegeService.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ITMCollegeService.Infrastructure.Services
{
    public class TmpService : IUserService
    {
        private IConfiguration _config;
        private IRepositoryWrapper _repositoryWrapper;
        private IMapper _mapper;
        public TmpService(IConfiguration config, IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _config = config;
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        public async Task<bool> Authenticate(LoginModel user)
        {
            var entity = await _repositoryWrapper.UserRepo.CheckUser(user);
            return entity != null;
        }

        // Importance
        public async Task<string> GenerateToken(LoginModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtToken:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var now = DateTime.UtcNow;
            var claims = new List<Claim>{
            new Claim(JwtRegisteredClaimNames.Sub, user.Username.ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64),
            new Claim(ClaimTypes.Name, user.Username)
            };
            // adding user to roles
            // Get all roles default user
            var tmp = await _repositoryWrapper.UserRoleRepo.UserRoles(user);
            foreach (var item in tmp)
            {
                claims.Add(new Claim(ClaimTypes.Role, item));
            }
            var token = new JwtSecurityToken(_config["JwtToken:Issuer"],
                _config["JwtToken:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddHours(12),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<LoginReturnDTO> Register(User request)
        {
            if (String.IsNullOrWhiteSpace(request.Username)) return new LoginReturnDTO(ErrCode.LoginEmpty);
            if (String.IsNullOrWhiteSpace(request.Password)) return new LoginReturnDTO(ErrCode.LoginEmpty);

            bool checkExistedUser = await _repositoryWrapper.UserRepo.CheckExistedUser(new LoginModel() { Username = request.Username, Password = request.Password });
            if (checkExistedUser) return new LoginReturnDTO(ErrCode.UserExist);
            var body = _mapper.Map<GetUserDTO>(await _repositoryWrapper.UserRepo.NewData(request));
            return new LoginReturnDTO { Msg = "Register successfully!", Info = body };
        }
    }
}
