using EImza.Application.Features.Auth.Login;
using EImza.Domain.Entities;

namespace EImza.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
