using AluraPic.Api.Auth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AluraPic.Api.Controllers
{
    [ApiController]
    [Route("user/[controller]")]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(User user)
        {
            // Gera o Token
            var token = TokenService.GenerateToken(user);
            user.token = token;

            if (user.userName == "ricardo")
            {
                return Ok(new User { userName = user.userName, token = user.token });
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("signup")]
        public IActionResult Signup(User newUser)
        {
            if (newUser.userName == "ricardo2")
            {
                return Ok(newUser);
            }

            return BadRequest();
        }
    }

    public class User
    {
        public string token { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}