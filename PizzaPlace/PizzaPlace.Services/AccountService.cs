using Microsoft.AspNetCore.Identity;
using PizzaPlace.Services.Interfaces;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<SignInResult> Login(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            var signInResult = new SignInResult();

            if(user != null)
            {
                signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
            }

            return signInResult;
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task Register(string username, string password)
        {
            var newUser = new IdentityUser()
            {
                UserName = username
            };

            var result = await _userManager.CreateAsync(newUser, password);

            if(result.Succeeded)
            {
              await _signInManager.PasswordSignInAsync(newUser, password, false, false);
            }
        }
    }
}
