using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SignatureRequestRepository : Repository<SignatureRequest>, ISignatureRequestRepository
    {
        public SignatureRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
