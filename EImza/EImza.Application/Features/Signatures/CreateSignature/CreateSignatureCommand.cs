using MediatR;
using TS.Result;

namespace EImza.Application.Features.Signatures.CreateSignature
{
    public sealed record CreateSignatureCommand(
        Guid DocumentId,
        Guid? DocumentVersionId,
        Guid CertificateId,
        string SignatureValue,
        string? Reason) : IRequest<Result<Guid>>;
}
