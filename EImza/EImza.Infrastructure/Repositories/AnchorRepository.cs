using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class AnchorRepository : Repository<Anchor, ApplicationDbContext>, IAnchorRepository
    {
        public AnchorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
