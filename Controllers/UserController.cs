using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAuth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [AllowAnonymous]
    public class UserController : BaseController
    { 
        private readonly TokenService _tokenService;
        public UserController(TokenService tokenService)
        {
            _tokenService = tokenService;
            
        }
        [HttpGet("GenerateToken")]
        public IActionResult GetToken()
        {
            var token = _tokenService.CreateToken();
            return Ok(new {token});
        }
    }
}