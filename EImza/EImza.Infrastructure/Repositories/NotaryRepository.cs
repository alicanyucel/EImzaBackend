using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class NotaryRepository : Repository<Notary, ApplicationDbContext>, INotaryRepository
    {
        public NotaryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
