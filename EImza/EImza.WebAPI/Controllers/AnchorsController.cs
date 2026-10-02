using EImza.Application.Features.Anchors.CreateAnchor;
using EImza.Application.Features.Anchors.DeleteAnchor;
using EImza.Application.Features.Anchors.GetAllAnchor;
using EImza.Application.Features.Anchors.GetByIdAnchor;
using EImza.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EImza.WebAPI.Controllers
{
    public sealed class AnchorsController : ApiController
    {
        public AnchorsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAnchorCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteAnchorCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAnchorQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] GetByIdAnchorQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
