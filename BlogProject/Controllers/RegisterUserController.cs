using BlogProject.Models;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    [AllowAnonymous]

    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

		public RegisterUserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUpViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.name,
                Surname = p.surname,
                Email = p.mail,
                UserName = p.userName,
                PhoneNumber = p.phoneNumber,
                ImageUrl = p.imageurl


			};
            if (p.password == p.confirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "RegisterUser");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignIn(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.userName, p.password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("EditProfile", "Writer");
				}
				else
				{
					return RedirectToAction("SignIn", "RegisterUser");
				}
			}
			return View();
		}
		public async Task<IActionResult> SignOut()
		{
			await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "RegisterUser");
        }

    }
}
