using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.GetByIdCertificateRequest
{
    public sealed record GetByIdCertificateRequestQuery(Guid Id) : IRequest<Result<CertificateRequest>>;
}
