using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace EImza.Application.Features.AuditLogs.GetAllAuditLog
{
    internal sealed class GetAllAuditLogQueryHandler(
        IAuditLogRepository auditLogRepository) : IRequestHandler<GetAllAuditLogQuery, Result<List<AuditLog>>>
    {
        public async Task<Result<List<AuditLog>>> Handle(GetAllAuditLogQuery request, CancellationToken cancellationToken)
        {
            var auditLogs = await auditLogRepository.GetAll()
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync(cancellationToken);

            return auditLogs;
        }
    }
}
