using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.UpdateCertificateAuthority
{
    internal sealed class UpdateCertificateAuthorityCommandHandler(
        ICertificateAuthorityRepository certificateAuthorityRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateCertificateAuthorityCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateCertificateAuthorityCommand request, CancellationToken cancellationToken)
        {
            var certificateAuthority = await certificateAuthorityRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificateAuthority is null)
            {
                return (500, "Sertifika otoritesi bulunamadı");
            }

            certificateAuthority.Name = request.Name;
            certificateAuthority.Url = request.Url;
            certificateAuthority.IsTrusted = request.IsTrusted;

            certificateAuthorityRepository.Update(certificateAuthority);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
