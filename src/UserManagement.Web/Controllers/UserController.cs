using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSwag.Annotations;

namespace UserManagement.Web.Controllers
{
    [ApiController]
    [Route("[api]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [OpenApiOperation("List all user data in UserManagement microservice", "Returns list of users.")]
        [HttpGet]
        public async Task<ActionResult<User>> Get()
        {
            var resultUser = new User();
            return Ok(resultUser);
        }

        [OpenApiOperation("Add new user point data in UserManagement microservice", "Returns Id of new user.")]
        [HttpPost]
        public async Task<ActionResult<User>> Add([FromBody] User body)
        {
             var resultUser = new User();
            return Ok(resultUser);
        }

        [OpenApiOperation("Mark user inactive in UserManagement microservice", "Returns success indicator.")]
        [HttpDelete]
        public async Task<ActionResult<User>> Delete([FromBody] User body)
        {
            var resultUser = new User();
            return Ok(resultUser);
        }
    }
}
