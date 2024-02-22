using Microsoft.AspNetCore.Mvc;
using ExampleName.Models;

namespace ExampleName.Controllers
{
  public class HomeController : Controller
  {
    private readonly ProjectNameContext _db;

    public HomeController(ProjectNameContext db)
    {
      _db = db;
    }

    [Route("/")]
    public ActionResult Index() { return View(); }
  }
}