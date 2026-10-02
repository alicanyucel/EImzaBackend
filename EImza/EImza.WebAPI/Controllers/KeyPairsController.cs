using EImza.Application.Features.KeyPairs.CreateKeyPair;
using EImza.Application.Features.KeyPairs.DeleteKeyPair;
using EImza.Application.Features.KeyPairs.GetAllKeyPair;
using EImza.Application.Features.KeyPairs.GetByIdKeyPair;
using EImza.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EImza.WebAPI.Controllers
{
    public sealed class KeyPairsController : ApiController
    {
        public KeyPairsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateKeyPairCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteKeyPairCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllKeyPairQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] GetByIdKeyPairQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
