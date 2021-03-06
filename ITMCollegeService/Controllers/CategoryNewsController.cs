using AutoMapper;
using ITMCollegeService.Contracts;
using ITMCollegeService.DTO;
using ITMCollegeService.Models;
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
    public class CategoryNewsController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public CategoryNewsController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sources = await _repositoryWrapper.CategoryNewsRepo.GetDataByIdAsync(id);
            if (sources == null)
            {
                return NotFound();
            }
            else
            {
                //_logger.LogInfo($"Return array Sources filted by hotelGUID");
                var sourceResults = _mapper.Map<GetCategoryNewsDTO>(sources);
                return Ok(sourceResults);
            }
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllData()
        {
            var sources = await _repositoryWrapper.CategoryNewsRepo.GetDatas();
            if (sources == null)
            {
                return NotFound();
            }
            else
            {
                //_logger.LogInfo($"Return array Sources filted by hotelGUID");
                var sourceResults = _mapper.Map<IEnumerable<GetCategoryNewsDTO>>(sources);
                return Ok(sourceResults);
            }
        }

        [Authorize(Roles = "Admin")]
        //[Authorize(Policy = "CreateSource")]
        [HttpPost("")]
        public async Task<IActionResult> CreateSource([FromBody] ModifyCategoryNewsDTO source)
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
                var sourceEntity = _mapper.Map<CategoryNews>(source);
                return Ok(_mapper.Map<GetCategoryNewsDTO>(await _repositoryWrapper.CategoryNewsRepo.NewData(sourceEntity)));
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
        public async Task<IActionResult> UpdateSource(int id, [FromBody] UpdateCategoryNewsDTO source)
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
                var sourceEntity = await _repositoryWrapper.CategoryNewsRepo.GetDataByIdAsync(id);
                if (sourceEntity == null)
                {
                    return NotFound();
                }
                int newsId = sourceEntity.NewsId;
                int categoryId = sourceEntity.CategoryId;
                _mapper.Map(source, sourceEntity);
                if(source.NewsId == 0)
                {
                    sourceEntity.NewsId = newsId;
                }
                if (source.CategoryId == 0)
                {
                    sourceEntity.CategoryId = categoryId;
                }
                _repositoryWrapper.CategoryNewsRepo.UpdateData(sourceEntity);
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
                var entity = await _repositoryWrapper.CategoryNewsRepo.GetDataByIdAsync(id);
                if (entity == null)
                {
                    return NotFound();
                }
                return Ok(await _repositoryWrapper.CategoryNewsRepo.DeleteData(entity));
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

        [HttpDelete("NewsId/{newsid}")]
        public async Task<IActionResult> DeleteCategoriesByNewsId(int newsid)
        {
            try
            {
                if (newsid <= 0)
                {
                    return BadRequest();
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                return Ok(await _repositoryWrapper.CategoryNewsRepo.ClearCategoryNewsById(newsid));
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
