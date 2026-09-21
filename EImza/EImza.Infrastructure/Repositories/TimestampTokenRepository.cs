using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class TimestampTokenRepository : Repository<TimestampToken, ApplicationDbContext>, ITimestampTokenRepository
    {
        public TimestampTokenRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
