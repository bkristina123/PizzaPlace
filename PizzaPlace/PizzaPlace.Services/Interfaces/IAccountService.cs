using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace PizzaPlace.Services.Interfaces
{
    public interface IAccountService
    {
        Task Register(string username, string password);
        Task<SignInResult> Login(string username, string password);
        Task LogOut();
    }
}
