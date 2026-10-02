using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.AuditLogs.GetAllAuditLog
{
    public sealed record GetAllAuditLogQuery() : IRequest<Result<List<AuditLog>>>;
}
