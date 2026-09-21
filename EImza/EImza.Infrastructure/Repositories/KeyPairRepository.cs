using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class KeyPairRepository : Repository<KeyPair, ApplicationDbContext>, IKeyPairRepository
    {
        public KeyPairRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
