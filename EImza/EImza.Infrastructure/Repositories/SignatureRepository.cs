using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SignatureRepository : Repository<Signature>, ISignatureRepository
    {
        public SignatureRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
