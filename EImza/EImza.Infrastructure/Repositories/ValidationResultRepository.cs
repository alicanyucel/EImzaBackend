using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class ValidationResultRepository : Repository<ValidationResult>, IValidationResultRepository
    {
        public ValidationResultRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
