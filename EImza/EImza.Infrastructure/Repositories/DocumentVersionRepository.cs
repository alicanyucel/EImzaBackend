using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class DocumentVersionRepository : Repository<DocumentVersion>, IDocumentVersionRepository
    {
        public DocumentVersionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
