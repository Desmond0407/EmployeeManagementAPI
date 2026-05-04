using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeServices _service;

        public EmployeeController(EmployeeServices service)
        {
            _service = service;
        }


       
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await _service.GetAllEmployees();
            return Ok(result);


        }

    }
}
