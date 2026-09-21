using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class NotaryRepository : Repository<Notary>, INotaryRepository
    {
        public NotaryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
