using EImza.Application.Features.AuditLogs.GetAllAuditLog;
using EImza.Application.Features.AuditLogs.GetByIdAuditLog;
using EImza.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EImza.WebAPI.Controllers
{
    public sealed class AuditLogsController : ApiController
    {
        public AuditLogsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAuditLogQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] GetByIdAuditLogQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
