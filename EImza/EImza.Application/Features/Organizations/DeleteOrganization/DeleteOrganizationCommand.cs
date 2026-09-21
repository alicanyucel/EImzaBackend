using MediatR;
using TS.Result;

namespace EImza.Application.Features.Organizations.DeleteOrganization
{
    public sealed record DeleteOrganizationCommand(Guid Id) : IRequest<Result>;
}
