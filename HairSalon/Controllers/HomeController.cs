using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Eau Claire's Salon";
      ViewBag.UnderTitleText = "something";
      return View();
    }
  }
}