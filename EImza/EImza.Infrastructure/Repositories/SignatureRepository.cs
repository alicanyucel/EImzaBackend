using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SignatureRepository : Repository<Signature, ApplicationDbContext>, ISignatureRepository
    {
        public SignatureRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
