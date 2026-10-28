using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestLogsController : ControllerBase
    {
        private readonly ILogger<TestLogsController> _logger;

        public TestLogsController(ILogger<TestLogsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult LogTest()
        {
            _logger.LogTrace("This is TRACE log message.");
            _logger.LogDebug("This is DEBUG log message.");
            _logger.LogInformation("This is INFORMATION log message.");
            _logger.LogWarning("This is WARNING log message.");
            _logger.LogError("This is ERROR log message.");
            _logger.LogCritical("This is CRITICAL log message.");
            return Ok("Log messages have been generated. Check your logging output.");
        }
    }
}
