using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class ApiKeyRepository : Repository<ApiKey, ApplicationDbContext>, IApiKeyRepository
    {
        public ApiKeyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
