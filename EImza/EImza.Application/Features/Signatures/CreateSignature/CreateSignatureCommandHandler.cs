using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;
using SignatureEntity = EImza.Domain.Entities.Signature;

namespace EImza.Application.Features.Signatures.CreateSignature
{
    internal sealed class CreateSignatureCommandHandler(
        ISignatureRepository signatureRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateSignatureCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateSignatureCommand request, CancellationToken cancellationToken)
        {
            var signature = new SignatureEntity
            {
                DocumentId = request.DocumentId,
                DocumentVersionId = request.DocumentVersionId,
                CertificateId = request.CertificateId,
                SignedAt = DateTime.UtcNow,
                SignatureValue = request.SignatureValue,
                Status = "Signed",
                Reason = request.Reason
            };

            await signatureRepository.AddAsync(signature, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return signature.Id;
        }
    }
}
