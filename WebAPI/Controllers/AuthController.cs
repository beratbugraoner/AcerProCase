using Business.Abstract;
using Core.Utilities.Results;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private readonly ILogger<AuthController> _logger;
        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            try
            {
                var userToLogin = _authService.Login(userForLoginDto);
                if (!userToLogin.Success)
                {

                    return BadRequest(userToLogin.Message);

                }
                var result = _authService.CreateAccessToken(userToLogin.Data);
                if (result.Success)
                {
                    return Ok(result.Data);

                }
                return BadRequest(result.Message);
            }
            catch (Exception ex)
            {

                _logger.LogError("Login failed for user : {0}{1}", userForLoginDto.Email, ex);
            }
            return BadRequest(new { Message = $"Login Failed for user: {userForLoginDto.Email}" });
        }


        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            try
            {
                var userExists = _authService.UserExists(userForRegisterDto.Email);
                throw new Exception("asd");
                if (!userExists.Success)
                {
                   
                    return BadRequest(userExists.Message);
                }
                var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
                var result = _authService.CreateAccessToken(registerResult.Data);
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError("Register failed for user : {0}{1}", userForRegisterDto.Email, ex);
                
            }
            return BadRequest(new { Message = $"Register Failed for user: {userForRegisterDto.Email}" });
        }
    }
}
