using MediatR;
using Microsoft.AspNetCore.Mvc;
using Students.CQRS.Commands;
using Students.CQRS.Queries;
using Students.DTOs;
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
        public async Task<ActionResult<IReadOnlyCollection<ReadStudentDto>>> Get()
        {
            var query = new GetStudentsQuery();
            var response = await _mediator.Send(query);

            return Ok(response);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ReadStudentDto>> Get([FromRoute] Guid id)
        {
            var query = new GetStudentByIdQuery(id);
            var response = await _mediator.Send(query);
            if (response is null) return NotFound();

            return Ok(response);
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateStudentDto dto)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var command = dto.MapToCreateStudentCommand();
            await _mediator.Send(command);

            var query = new GetStudentByIdQuery(command.GeneratedId);
            var response = await _mediator.Send(query);

            return CreatedAtAction(nameof(Get), new { response.Id}, response);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> Post([FromRoute] Guid id, [FromBody] UpdateStudentDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var command = dto.MapToUpdateStudentCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpPatch("ativar/{id:guid}")]
        public async Task<ActionResult> Patch([FromRoute] Guid id)
        {
            var command = new ActivateStudentCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            var command = new DeleteStudentCommand(id);
            await _mediator.Send(command);

            return Ok();
        }
    }
}
