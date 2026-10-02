using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.CertificateRequests.CreateCertificateRequest
{
    internal sealed class CreateCertificateRequestCommandHandler(
        ICertificateRequestRepository certificateRequestRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateCertificateRequestCommand, Result<Guid>>
    {
        public async Task<Result<Guid>> Handle(CreateCertificateRequestCommand request, CancellationToken cancellationToken)
        {
            var certificateRequest = new CertificateRequest
            {
                RequesterUserId = request.RequesterUserId,
                OrganizationId = request.OrganizationId,
                Csr = request.Csr,
                Status = "Pending",
                CreatedAt = DateTime.UtcNow
            };

            await certificateRequestRepository.AddAsync(certificateRequest, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return certificateRequest.Id;
        }
    }
}
