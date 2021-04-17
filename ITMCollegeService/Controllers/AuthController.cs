using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ITMCollegeService.Contracts;
using ITMCollegeService.DTO;
using ITMCollegeService.Identity;
using ITMCollegeService.Infrastructure.Services;
using ITMCollegeService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ITMCollegeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public AuthController(IConfiguration config, IMapper mapper, IUserService userService, IRepositoryWrapper repositoryWrapper)
        {
            _config = config;
            _userService = userService;
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("[Action]")]
        public async Task<LoginReturnDTO> Login([FromBody]LoginModel user)
        {
            if (user == null) return new LoginReturnDTO(ErrCode.LoginEmpty);
            string tokenString = string.Empty;
            bool validUser = await _userService.Authenticate(user);
            if (validUser)
            {
                tokenString = await _userService.GenerateToken(user);
            }
            else
            {
                return new LoginReturnDTO(ErrCode.PassWrong);
            }
            var info = new LoginReturnDTO
            {
                Msg = "Login successfully",
                Token = tokenString,
                Info = _mapper.Map<GetUserDTO>(await _repositoryWrapper.UserRepo.CheckUser(user))
            };
            return info;
        }

        [HttpPost("[Action]")]
        [Authorize]
        public async Task<LoginReturnDTO> Logout([FromBody]LoginModel user)
        {
            if (user == null) return new LoginReturnDTO(ErrCode.LoginEmpty);
            string tokenString = string.Empty;
            bool validUser = await _userService.Authenticate(user);
            if (validUser)
            {
                tokenString = await _userService.GenerateToken(user);
            }
            else
            {
                return new LoginReturnDTO(ErrCode.PassWrong);
            }
            var info = new LoginReturnDTO
            {
                Msg = "Login successfully",
                Token = tokenString
            };
            return info;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("[Action]")]
        public async Task<ActionResult<LoginReturnDTO>> Register([FromBody] ModifyUserDTO body)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                var result = await _userService.Register(_mapper.Map<User>(body));
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}