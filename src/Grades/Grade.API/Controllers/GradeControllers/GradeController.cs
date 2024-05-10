using Grade.Application.Abstractions;
using Grade.Application.UseCases.GradeCases.Commands;
using Grade.Application.UseCases.GradeCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grade.API.Controllers.GradeControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GradeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGrade(CreateGradeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGrades()
        {
            var result = await _mediator.Send(new GetAllGradesQuery());
            return Ok(result);
        }

       

    }
}
