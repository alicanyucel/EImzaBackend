using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class CertificateAuthorityRepository : Repository<CertificateAuthority>, ICertificateAuthorityRepository
    {
        public CertificateAuthorityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
