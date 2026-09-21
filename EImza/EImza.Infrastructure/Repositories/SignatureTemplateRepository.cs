using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SignatureTemplateRepository : Repository<SignatureTemplate>, ISignatureTemplateRepository
    {
        public SignatureTemplateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
