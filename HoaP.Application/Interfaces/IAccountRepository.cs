using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IAccountRepository
    {
        Task<LoginResult> LoginAsync(string email, string password);
        Task LogoutAsync();
        Task UpdateUserProfileAsync(AppUser user);
        Task RegisterEmployeeAsync(AppUser user, string password, string? roleId);
        Task<List<AppRole>> GetRolesAsync();
    }
}
