using Microsoft.AspNetCore.Mvc;
using ExampleName.Models;

namespace ExampleName.Controllers
{
  public class ExampleNameController : Controller
  {
    private readonly ProjectNameContext _db;

    public ExampleNameController(ProjectNameContext db)
    {
      _db = db;
    }

    [Route("/")]
    public string Index() { return View(); }
  }
}