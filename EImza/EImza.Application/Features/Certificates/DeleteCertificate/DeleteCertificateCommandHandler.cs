using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Certificates.DeleteCertificate
{
    internal sealed class DeleteCertificateCommandHandler(
        ICertificateRepository certificateRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteCertificateCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeleteCertificateCommand request, CancellationToken cancellationToken)
        {
            var certificate = await certificateRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificate is null)
            {
                return (500, "Sertifika bulunamadı");
            }

            certificateRepository.Delete(certificate);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
