using Business_Logic_Layer.Repository;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllConcepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthDataRepository<LoginModel>? _authDataRepository;
        public AuthenticationController(IAuthDataRepository<LoginModel>? authDataRepository)
        {
            _authDataRepository = authDataRepository;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel user)
        {
            var user1=_authDataRepository.CheckAuth(user.UserName, user.Password);
            if (user1 == null)
            {
                return BadRequest("Invalid Client Request");
            }
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VinaySecretKey@345"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: "http://localhost:5085",
                audience: "http://localhost:5085",
                claims: new List<Claim>(),
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return Ok(new Authenticate_Token { Token = tokenString });
        }
    }
}
