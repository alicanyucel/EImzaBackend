using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class CertificateAuthorityRepository : Repository<CertificateAuthority, ApplicationDbContext>, ICertificateAuthorityRepository
    {
        public CertificateAuthorityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
