using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.DeleteCertificateAuthority
{
    internal sealed class DeleteCertificateAuthorityCommandHandler(
        ICertificateAuthorityRepository certificateAuthorityRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteCertificateAuthorityCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteCertificateAuthorityCommand request, CancellationToken cancellationToken)
        {
            var certificateAuthority = await certificateAuthorityRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificateAuthority is null)
            {
                return (500, "Sertifika otoritesi bulunamadı");
            }

            certificateAuthorityRepository.Delete(certificateAuthority);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
