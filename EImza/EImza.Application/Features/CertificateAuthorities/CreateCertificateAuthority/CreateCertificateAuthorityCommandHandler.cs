using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateAuthorities.CreateCertificateAuthority
{
    internal sealed class CreateCertificateAuthorityCommandHandler(
        ICertificateAuthorityRepository certificateAuthorityRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateCertificateAuthorityCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateCertificateAuthorityCommand request, CancellationToken cancellationToken)
        {
            var certificateAuthority = new CertificateAuthority
            {
                Name = request.Name,
                Url = request.Url,
                IsTrusted = request.IsTrusted
            };

            await certificateAuthorityRepository.AddAsync(certificateAuthority, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return certificateAuthority.Id;
        }
    }
}
