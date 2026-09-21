using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class DocumentVersionRepository : Repository<DocumentVersion, ApplicationDbContext>, IDocumentVersionRepository
    {
        public DocumentVersionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
