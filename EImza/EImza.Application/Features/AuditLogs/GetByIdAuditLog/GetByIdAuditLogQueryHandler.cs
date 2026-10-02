using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.AuditLogs.GetByIdAuditLog
{
    internal sealed class GetByIdAuditLogQueryHandler(
        IAuditLogRepository auditLogRepository) : IRequestHandler<GetByIdAuditLogQuery, Result<AuditLog>>
    {
        public async Task<Result<AuditLog>> Handle(GetByIdAuditLogQuery request, CancellationToken cancellationToken)
        {
            var auditLog = await auditLogRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (auditLog is null)
            {
                return (500, "Denetim kaydı bulunamadı");
            }

            return auditLog;
        }
    }
}
