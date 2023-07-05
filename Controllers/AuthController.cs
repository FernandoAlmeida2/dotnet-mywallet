using dotnet_mywallet.Dtos.User;
using dotnet_mywallet.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mywallet.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("signup")]
        public async Task<ActionResult<ServiceResponse<int>>> SignUp(UserRegisterDto newUserDto)
        {
            var newUser = new User
            {
                Name = newUserDto.Name,
                Email = newUserDto.Email,
            };

            var response = await _authRepo.InsertOne(newUser, newUserDto.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Created("Create an user", response);
        }
    }
}