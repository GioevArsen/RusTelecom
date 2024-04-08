using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RusTelecom.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RusTelecom.Controllers
{
    public class ContractController : Controller
    {
        private readonly ILogger<ContractController> _logger;

        public ContractController(ILogger<ContractController> logger)
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
