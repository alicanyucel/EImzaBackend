using EImza.Domain.Entities;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.GetAllCertificate
{
    public sealed record GetAllCertificateQuery() : IRequest<Result<List<Certificate>>>;
}
