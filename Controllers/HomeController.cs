using ManutencaoPlano.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ManutencaoPlano.Data;

namespace ManutencaoPlano.Controllers
{
    public class HomeController : Controller
    {
        private readonly planodiarioContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, planodiarioContext context)
        {
            db = context;
            db.Database.EnsureCreated();
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = db.FtAbateQuarteioHabilitacao.ToList();
            return View(model);
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
