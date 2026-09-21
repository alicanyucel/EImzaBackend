using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.GetByIdCertificate
{
    public sealed record GetByIdCertificateQuery(Guid Id) : IRequest<Result<Certificate>>;
}
