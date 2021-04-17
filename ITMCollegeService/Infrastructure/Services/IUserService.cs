using ITMCollegeService.Identity;
using ITMCollegeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Infrastructure.Services
{
    public interface IUserService
    {
        Task<bool> Authenticate(LoginModel user);
        Task<LoginReturnDTO> Register(User user);
        Task<string> GenerateToken(LoginModel user);
    }
}
