using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.AuditLogs.GetByIdAuditLog
{
    public sealed record GetByIdAuditLogQuery(Guid Id) : IRequest<Result<AuditLog>>;
}
