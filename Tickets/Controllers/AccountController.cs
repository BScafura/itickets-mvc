using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Tickets.Data;
using Tickets.Data.ViewModels;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;


        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context; 

        }

        //[HttpPost("register")]
        //public async Task<IActionResult> Register([FromBody] Registo registo)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //            return BadRequest(ModelState);

        //        var applicationUser = new ApplicationUser { UserName = registo.Username, Email = registo.Email };
        //        var createUser = await _userManager.CreateAsync(applicationUser, registo.Password);

        //        if (createUser.Succeeded) {
        //            var roleResult = await _userManager.AddToRoleAsync(applicationUser, "User");
        //            if (roleResult.Succeeded)
        //            {
        //                return Ok("Registo efetuado com sucesso");
        //            }
        //            else
        //            {
        //                return StatusCode(500, roleResult.Errors);
        //            }
        //        }
        //        else
        //        {
        //            return StatusCode(500, createUser.Errors);
        //        }
                
        //    }
        //    catch (Exception e)
        //    {

        //        return StatusCode(500, e);
        //    }

        //}
        
        public IActionResult Login()
        {
            var response = new LoginVM();
            
            return View(response);
        }
        
        [HttpPost]
        public  async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded) {
                            
                        return RedirectToAction("Index", "Filme");
                    }
                }
                TempData["ERRO!"] = "Utilizador nao encontrado!";
                return View(loginVM);
            }
            TempData["ERRO!"] = "Utilizador nao encontrado!";
            return View(loginVM);
        }

        public IActionResult Register()
        {
            var response = new RegisterVM();

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }

         
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
                if (user != null)
                {

                    return View("Register");

                }
                else
                {
                    var newUser = new ApplicationUser()
                    {

                        Email = registerVM.EmailAddress,
                        UserName = registerVM.EmailAddress,


                    };
                    try
                    {
                        var newUserCreate = await _userManager.CreateAsync(newUser, registerVM.Password);
                        if (newUserCreate.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(newUser, "User");
                            return View("RegistoConcluido");
                        }
                    }
                    catch (Exception)
                    {


                    }
                }

                return View("Register");
            }
         
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Filme");
        }

    }
}
