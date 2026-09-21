using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class SignatureTemplateRepository : Repository<SignatureTemplate, ApplicationDbContext>, ISignatureTemplateRepository
    {
        public SignatureTemplateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
