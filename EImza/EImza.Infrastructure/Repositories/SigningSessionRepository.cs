using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SigningSessionRepository : Repository<SigningSession, ApplicationDbContext>, ISigningSessionRepository
    {
        public SigningSessionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
