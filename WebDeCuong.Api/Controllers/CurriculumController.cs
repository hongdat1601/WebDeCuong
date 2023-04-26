using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Api.Cons;
using Microsoft.AspNetCore.Authorization;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDeCuong.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CurriculumController : ControllerBase
    {
        private readonly ICurriculumRepository _curriculumRepository;

        public CurriculumController(ICurriculumRepository curriculumRepository)
        {
            _curriculumRepository = curriculumRepository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _curriculumRepository.GetAllCurriculum());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET api/values/5
        [HttpGet("GetById")]
        public async Task<IActionResult> GetSubjectById([FromQuery] int id)
        {
            try
            {
                var res = await _curriculumRepository.GetCurriculum(id);
                if (res.Status.CompareTo(Status.Success) == 0)
                {
                    return Ok(res);
                }
                return BadRequest(res.Message);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/values
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] CurriculumModel curriculum)
        {
            var result = await _curriculumRepository.AddCurriculum(curriculum);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result.Message);
            return Ok(result.Message);

        }

        // PUT api/values/5
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CurriculumUupdate([FromBody] CurriculumModel curriculum)
        {
            var result = await _curriculumRepository.UpdateCurriculum(curriculum);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var result = await _curriculumRepository.DeleteCurriculum(id);
            if (result.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}

