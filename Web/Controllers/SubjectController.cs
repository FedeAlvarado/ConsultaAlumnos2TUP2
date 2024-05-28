using Application.Models;
using Application.Models.Requests;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService _subjectService;
        public SubjectController(SubjectService subject) 
        { 
            _subjectService = subject;
        }

        [HttpGet("/{id}")]
        public ActionResult<SubjectDto> GetById(int id)
        {
            return _subjectService.GetById(id);
        }

        [HttpPost]
        public ActionResult<SubjectDto> Create(SubjectCreateRequest subjectDto)
        {
            return _subjectService.Create(subjectDto);
        }
    }
}
