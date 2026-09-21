using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class AnchorRepository : Repository<Anchor>, IAnchorRepository
    {
        public AnchorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
