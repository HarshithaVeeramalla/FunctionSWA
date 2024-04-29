using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AppInsights
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogTrace($">>> Log Trace");
            _logger.LogDebug($">>> Log Debug");
            _logger.LogInformation($">>> Log Information");
            _logger.LogWarning($">>> Log Warning");
            _logger.LogError($">>> Log Error");
            _logger.LogCritical($">>> Log Critical");

            Console.WriteLine($">>> Console WriteLine");

            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
