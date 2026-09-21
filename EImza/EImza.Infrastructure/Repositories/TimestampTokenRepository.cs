using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class TimestampTokenRepository : Repository<TimestampToken>, ITimestampTokenRepository
    {
        public TimestampTokenRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
