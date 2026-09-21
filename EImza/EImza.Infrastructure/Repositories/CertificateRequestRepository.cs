using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class CertificateRequestRepository : Repository<CertificateRequest>, ICertificateRequestRepository
    {
        public CertificateRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
