using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using LoginPage.Business;

namespace LoginPage.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationManager _authenticationManager;

        public AuthenticationController(AuthenticationManager authenticationManager)
        {
            _authenticationManager = authenticationManager;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginRequest request)
        {
            bool areCredentialsValid = _authenticationManager.ValidateCredentials(request.Username, request.Password);
            if (areCredentialsValid)
            {
                return Ok(new { message = "Login successful!" });
            }
            else
            {
                return Unauthorized(new { message = "Invalid credentials." });
            }
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}