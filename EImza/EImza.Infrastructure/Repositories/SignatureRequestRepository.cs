using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SignatureRequestRepository : Repository<SignatureRequest, ApplicationDbContext>, ISignatureRequestRepository
    {
        public SignatureRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
