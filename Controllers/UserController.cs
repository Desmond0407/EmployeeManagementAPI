using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserServices _services;

        public UserController(UserServices services)
        {
            _services = services;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register (RegisterDTO dto)
        {
            var result = await _services.Register(dto);

            return Ok(result);
        }


        [HttpPut("update")]

        public async Task<IActionResult> UpdateUpdatePasswordAsyc(UpdateDTO dto)
        {
            var result = await _services.UpdatePasswordAsyc (dto);

            return Ok(result);
        }
    }
}
