using IntermediateProject.Domain.Entities.Identity.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace IntermediateProject.Application.Abstraction.TokenProviding
{
	public interface ITokenService
	{
		Task<JwtSecurityToken> CreateTokenAsync(
			AppUser user,
			IList<string> roles);

		string GenerateRefreshToken();

		ClaimsPrincipal GetPrincipalFromExpiredToken(string? token);

		DateTime GetRefreshTokenExpireDate();
	}

}
