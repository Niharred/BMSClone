using BMSClone.DTOs;
using BMSClone.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BMSClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IAuthService _authService;
        public AuthController(IAuthService authService)
        { 
        _authService = authService;
        
        }

        [HttpPost]
        public void Login(LoginRequestDTO loginRequestDTO)
        { 
        
        
        
        
        
        }

        [HttpGet]
        public void Logout()
        { 
        
        
        
        }
    }
}
