using MediatR;

namespace EImza.Application.Features.Signature.CreateSignature;

public sealed record CreateSignatureCommand(
Guid DocumentId,
Guid? DocumentVersionId,
Guid CertificateId,
string SignatureValue,
string? Reason
) : IRequest<Guid>;
