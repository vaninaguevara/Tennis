using Tennis.API.Models.Request;
using Tennis.Models;

namespace Tennis.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> ValidateUserAsync(UsuarioRequest usuarioRequest);
        Task CreateUserAsync(UsuarioRequest usuarioRequest);
        Task<Usuario> GetUserByRefreshTokenAsync(string refreshToken);
    }
}
