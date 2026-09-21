using EImza.Domain.Entities;
using EImza.Domain.Repositories;
using EImza.Infrastructure.Context;
using GenericRepository;

namespace EImza.Infrastructure.Repositories
{
    internal sealed class ValidationResultRepository : Repository<ValidationResult, ApplicationDbContext>, IValidationResultRepository
    {
        public ValidationResultRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
