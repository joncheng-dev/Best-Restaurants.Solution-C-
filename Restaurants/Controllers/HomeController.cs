using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}