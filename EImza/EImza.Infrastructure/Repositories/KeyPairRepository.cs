using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class KeyPairRepository : Repository<KeyPair>, IKeyPairRepository
    {
        public KeyPairRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
