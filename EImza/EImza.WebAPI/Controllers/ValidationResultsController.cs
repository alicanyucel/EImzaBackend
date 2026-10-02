using EImza.Application.Features.ValidationResults.CreateValidationResult;
using EImza.Application.Features.ValidationResults.GetAllValidationResult;
using EImza.Application.Features.ValidationResults.GetByIdValidationResult;
using EImza.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EImza.WebAPI.Controllers
{
    public sealed class ValidationResultsController : ApiController
    {
        public ValidationResultsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateValidationResultCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllValidationResultQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] GetByIdValidationResultQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
