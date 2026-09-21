using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SigningSessionRepository : Repository<SigningSession>, ISigningSessionRepository
    {
        public SigningSessionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
