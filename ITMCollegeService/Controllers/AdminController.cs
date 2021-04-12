using ITMCollegeService.DTO;
using ITMCollegeService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepo _adminRepo;
        public AdminController(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllAdmins()
        {
            return Ok(await _adminRepo.GetAllAdmins());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllAdmins(int id)
        {
            try
            {
                return Ok(await _adminRepo.GetAdminById(id));
            }
            catch(Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.Message + "," + ex.InnerException.Message);
                }
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateAdminAsync([FromBody]CreateAdminDTO body)
        {
            return Ok(await _adminRepo.CreateAdminAsync(body));
        }
    }
}
