using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.UpdateCertificateRequest
{
    internal sealed class UpdateCertificateRequestCommandHandler(
        ICertificateRequestRepository certificateRequestRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateCertificateRequestCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(UpdateCertificateRequestCommand request, CancellationToken cancellationToken)
        {
            var certificateRequest = await certificateRequestRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (certificateRequest is null)
            {
                return (500, "Sertifika talebi bulunamadı");
            }

            certificateRequest.Status = request.Status;

            certificateRequestRepository.Update(certificateRequest);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
