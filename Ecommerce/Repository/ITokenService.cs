using Ecommerce.Models;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public interface ITokenService
    {
        Task<string> CreateToken(ApplicationUser user);
    }
}
