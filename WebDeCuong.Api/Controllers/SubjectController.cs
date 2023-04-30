using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Api.Cons;
using Microsoft.AspNetCore.Authorization;
using WebDeCuong.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDeCuong.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SubjectController : ControllerBase
    {
        // GET: api/values
        private readonly ISubjectRepository _subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        [HttpPost("Request")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> RequestSubject([FromBody] RequestSubjectModel subject)
        {
            var res = await _subjectRepository.RequestSubject(subject);

            if (res.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(res.Message);
            }

            return Ok(res.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _subjectRepository.GetAllSubject());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetSubjectById([FromQuery] string id)
        {
            try
            {
                var res = await _subjectRepository.GetSubject(id);
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

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] SubjectModel subject)
        {
            var result = await _subjectRepository.AddSubject(subject);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result.Message);
            return Ok(result.Message);

        }

        [HttpPut()]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateSubject([FromBody] SubjectModel subject)
        {
            var result = await _subjectRepository.UpdateSubject(subject);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteSubject([FromQuery] string Id)
        {
            var result = await _subjectRepository.DeleteSubject(Id);
            if (result.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        
    }   
}

