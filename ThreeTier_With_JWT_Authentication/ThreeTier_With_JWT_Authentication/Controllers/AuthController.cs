using BusinessLogicLayer.Repository;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThreeTier_With_JWT_Authentication.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthDataRepository<LoginModel>? _authDataRepository;
        public AuthController(IAuthDataRepository<LoginModel>? authDataRepository)
        {
            _authDataRepository = authDataRepository;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel user)
        {
            var user1=_authDataRepository.Checkauth(user.UserName, user.Password);
            if (user1 == null)
            {
                return BadRequest("Invalid client request");
            }
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: "https://localhost:7201",
                audience: "https://localhost:7201",
                claims: new List<Claim>(),
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return Ok(new AuthenticatedResponse { Token = tokenString });
        }
    }
}
