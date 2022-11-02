using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.WebAPI.Models.Requests;
using AspNetSample.WebAPI.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace AspNetSample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IJwtUtil _jwtUtil;
        private readonly IMapper _mapper;

        public UserController(IUserService userService,
            IRoleService roleService, 
            IMapper mapper, 
            IJwtUtil jwtUtil)
        {
            _userService = userService;
            _roleService = roleService;
            _mapper = mapper;
            _jwtUtil = jwtUtil;
        }

        
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }


        /// <summary>
        /// Register user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegisterUserRequestModel request)
        {
            try
            {
                var userRoleId = await _roleService.GetRoleIdByNameAsync("User");
                var userDto = _mapper.Map<UserDto>(request);
                var userWIthSameEmailExists = await _userService.IsUserExists(request.Email);
                if (userDto != null
                    && userRoleId != null
                    && !userWIthSameEmailExists
                    && request.Password.Equals(request.PasswordConfirmation))
                {
                    userDto.RoleId = userRoleId.Value;
                    var result = await _userService.RegisterUser(userDto, request.Password);
                    if (result > 0)
                    {
                        var userInDbDto = await _userService.GetUserByEmailAsync(userDto.Email);

                        var response = _jwtUtil.GenerateToken(userInDbDto);

                        return Ok(response);
                    }
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                return StatusCode(500);
            }
        }
    }
}
