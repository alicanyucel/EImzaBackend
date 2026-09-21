using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.DeleteCertificate
{
    public sealed record DeleteCertificateCommand(Guid Id) : IRequest<Result<bool>>;
}
