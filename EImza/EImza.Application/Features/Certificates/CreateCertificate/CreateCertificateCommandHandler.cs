using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.CreateCertificate
{
    internal sealed class CreateCertificateCommandHandler(
        ICertificateRepository certificateRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateCertificateCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateCertificateCommand request, CancellationToken cancellationToken)
        {
            var certificate = new Certificate
            {
                SerialNumber = request.SerialNumber,
                AuthorityId = request.AuthorityId,
                OwnerUserId = request.OwnerUserId,
                OrganizationId = request.OrganizationId,
                IssuedAt = request.IssuedAt,
                ExpiresAt = request.ExpiresAt,
                IsRevoked = false,
                RawDataBase64 = request.RawDataBase64
            };

            await certificateRepository.AddAsync(certificate, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return certificate.Id;
        }
    }
}
