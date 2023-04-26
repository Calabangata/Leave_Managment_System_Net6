using LeaveManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeaveManagmentSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            var ExceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (ExceptionHandlerPathFeature != null)
            {
                Exception exception = ExceptionHandlerPathFeature.Error;
                _logger.LogError(exception, $"Error, encountered by user: {this.User?.Identity?.Name} | Request Id: {requestId}");
            }

            return View(new ErrorViewModel { RequestId = requestId  });
        }
    }
}