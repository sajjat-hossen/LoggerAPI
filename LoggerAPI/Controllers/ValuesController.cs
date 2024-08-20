using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ValuesController));

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            log.Info("Login Action start");

            // More code here ...
            log.Info("Login Action end");

            return Ok();
        }

        // More code here...

        [HttpGet]
        public async Task<IActionResult> logout()
        {
            log.Warn("Logout Action Start");
            log.Warn("Logout Action End");

            return Ok("logout successfully");
        }
    }
}
