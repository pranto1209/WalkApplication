using Microsoft.AspNetCore.Identity;

namespace WalkApplicationAPI.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
