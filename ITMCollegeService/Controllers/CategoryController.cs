﻿using AutoMapper;
using ITMCollegeService.Contracts;
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
    public class CategoryController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public CategoryController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sources = await _repositoryWrapper.ContactRepo.GetDataByIdAsync(id);
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

        [HttpGet("")]
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
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.Message + "," + ex.InnerException.Message);
                }
                return BadRequest(ex.Message);
            }
        }
    }
}
