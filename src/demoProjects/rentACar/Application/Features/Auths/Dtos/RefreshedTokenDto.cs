using Core.Security.Entities;
using Core.Security.JWT;

namespace Application.Features.Auths.Dtos
{
    public class RefreshedTokenDto
    {
        public AccessToken accessToken { get; set; }
        public RefreshToken refreshToken { get; set; }
    }
}