using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.UpdateCertificate
{
    internal sealed class UpdateCertificateCommandHandler(
        ICertificateRepository certificateRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateCertificateCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateCertificateCommand request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificate is null)
            {
                return (500, "Sertifika bulunamadı");
            }

            certificate.SerialNumber = request.SerialNumber;
            certificate.AuthorityId = request.AuthorityId;
            certificate.OwnerUserId = request.OwnerUserId;
            certificate.OrganizationId = request.OrganizationId;
            certificate.IssuedAt = request.IssuedAt;
            certificate.ExpiresAt = request.ExpiresAt;
            certificate.IsRevoked = request.IsRevoked;
            certificate.RawDataBase64 = request.RawDataBase64;

            certificateRepository.Update(certificate);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
