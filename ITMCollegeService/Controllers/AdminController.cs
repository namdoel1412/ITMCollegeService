using AutoMapper;
using ITMCollegeService.Contracts;
using ITMCollegeService.DTO;
using ITMCollegeService.Models;
using ITMCollegeService.Repositories;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public AdminController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sources = await _repositoryWrapper.AdminRepo.GetDataByIdAsync(id);
            if (sources == null)
            {
                return NotFound();
            }
            else
            {
                //_logger.LogInfo($"Return array Sources filted by hotelGUID");
                var sourceResults = _mapper.Map<GetAdminDTO>(sources);
                return Ok(sourceResults);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllData()
        {
            var sources = await _repositoryWrapper.AdminRepo.GetDatas();
            if (sources == null)
            {
                return NotFound();
            }
            else
            {
                //_logger.LogInfo($"Return array Sources filted by hotelGUID");
                var sourceResults = _mapper.Map<IEnumerable<GetAdminDTO>>(sources);
                return Ok(sourceResults);
            }
        }

        //[Authorize(Policy = "CreateSource")]
        [Authorize(Roles = "Admin")]
        [HttpPost("")]
        public async Task<IActionResult> CreateSource([FromBody] ModifyAdminDTO source)
        {
            try
            {
                if (source == null)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                var sourceEntity = _mapper.Map<Admin>(source);
                return Ok(await _repositoryWrapper.AdminRepo.NewData(sourceEntity));
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong inside CreateSources action: {ex.Message}");
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.Message + "," + ex.InnerException.Message);
                }
                return BadRequest(ex.Message);
            }
        }

        //[Authorize(Policy = "UpdateSource")]
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSource(int id, [FromBody] UpdateAdminDTO source)
        {
            try
            {
                if (source == null)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                var sourceEntity = await _repositoryWrapper.AdminRepo.GetDataByIdAsync(id);
                if (sourceEntity == null)
                {
                    return NotFound();
                }
                int genderId = sourceEntity.GenderId;
                _mapper.Map(source, sourceEntity);
                if (source.GenderId == 0)
                {
                    sourceEntity.GenderId = genderId;
                }
                _repositoryWrapper.AdminRepo.UpdateData(sourceEntity);
                await _repositoryWrapper.SaveAsync();
                return Ok("Update successfully!");
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong inside CreateSources action: {ex.Message}");
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.Message + "," + ex.InnerException.Message);
                }
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteData(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                var entity = await _repositoryWrapper.AdminRepo.GetDataByIdAsync(id);
                if (entity == null)
                {
                    return NotFound();
                }
                return Ok(await _repositoryWrapper.AdminRepo.DeleteData(entity));
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
        //private readonly IAdminRepo _adminRepo;
        //public AdminController(IAdminRepo adminRepo)
        //{
        //    _adminRepo = adminRepo;
        //}
        //[HttpGet("")]
        //public async Task<IActionResult> GetAllAdmins()
        //{
        //    return Ok(await _adminRepo.GetAllAdmins());
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetAllAdmins(int id)
        //{
        //    try
        //    {
        //        return Ok(await _adminRepo.GetAdminById(id));
        //    }
        //    catch(Exception ex)
        //    {
        //        if (ex.InnerException != null)
        //        {
        //            return BadRequest(ex.Message + "," + ex.InnerException.Message);
        //        }
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpPost("")]
        //public async Task<IActionResult> CreateAdminAsync([FromBody]CreateAdminDTO body)
        //{
        //    return Ok(await _adminRepo.CreateAdminAsync(body));
        //}
    }
}
