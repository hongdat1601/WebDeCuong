using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Data.Entities;
using WebDeCuong.Data;
using Microsoft.EntityFrameworkCore;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Api.Repositories;
using WebDeCuong.Api.Cons;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDeCuong.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        // GET: api/values
        private readonly ISubjectRepository _subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_subjectRepository.GetAllSubject());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] SubjectModel subject)
        {
            var result = await _subjectRepository.AddSubject(subject);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);

        }
        [HttpGet("{id}")]
        public IActionResult GetSubjectById(int id)
        {
            try {

                var subject = _subjectRepository.GetById(id);
                if (subject != null)
                {
                    return Ok(subject);
                }
                return NotFound();

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubject([FromForm] SubjectModel subject, int id)
        {
            var result = await _subjectRepository.UpdateSubject(subject,id);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            var result = await _subjectRepository.DeleteSubject(id);
            if (result.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        
    }   
}

