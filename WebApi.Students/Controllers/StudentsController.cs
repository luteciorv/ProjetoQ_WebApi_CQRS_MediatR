using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Students.CQRS.Commands;
using Students.CQRS.Queries;
using Students.DTOs;
using Students.Entities;
using Students.Extensions;

namespace Students.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<Student>>> Get()
        {
            var command = await _mediator.Send(new GetStudentsQuery());
            return Ok(command);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateStudentDto dto)
        {
            var command = dto.MapToCommand();
            await _mediator.Send(command);

            return Ok(command.Id);
        }
    }
}
