using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.GetAllCertificateRequest
{
    public sealed record GetAllCertificateRequestQuery() : IRequest<Result<List<CertificateRequest>>>;
}
