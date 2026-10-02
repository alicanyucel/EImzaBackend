using EImza.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace EImza.Application.Features.Permissions.DeletePermission
{
    internal sealed class DeletePermissionCommandHandler(
        IPermissionRepository permissionRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<DeletePermissionCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(DeletePermissionCommand request, CancellationToken cancellationToken)
        {
            var permission = await permissionRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (permission is null)
            {
                return (500, "Yetki bulunamadı");
            }

            permissionRepository.Delete(permission);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
