using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mywallet.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetHealth() {
            return Ok("OK!");
        }
    }
}