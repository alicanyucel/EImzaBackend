using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class CertificateRequestRepository : Repository<CertificateRequest, ApplicationDbContext>, ICertificateRequestRepository
    {
        public CertificateRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
