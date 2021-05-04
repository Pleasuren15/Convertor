using Convertor.Data;
using Microsoft.AspNetCore.Mvc;

namespace Convertor.Controllers
{
    public class HomeController : Controller
    {
        public IRepositoryWrapper repositoryWrapper { get; }

        public HomeController(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public IActionResult Index()
        {
            return View(repositoryWrapper._categories.FindAll());
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}