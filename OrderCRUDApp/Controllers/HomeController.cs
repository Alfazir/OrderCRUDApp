using Microsoft.AspNetCore.Mvc;
using OrderCRUDApp.Models;
using OrderCRUDApp.Repos;
using OrderCRUDApp.Repos.Interfaces;
using System.Diagnostics;
using System.Dynamic;

namespace OrderCRUDApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly UnitOfWork _UoW;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow)
        {
            _logger = logger;

            this._UoW = uow as UnitOfWork;
        }

        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.Orders = this._UoW.OrderRepository.GetAll();
            return View("Index", model);
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