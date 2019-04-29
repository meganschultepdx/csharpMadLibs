using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madLibs")]
    public ActionResult MadLibs(string sillyName, string unrealisticProfession, string country, string anotherSillyName, string color, string adjective)
    {
      MadLibs myMadLibs = new MadLibs();
      myMadLibs.SillyName(sillyName);
      myMadLibs.UnrealisticProfession(unrealisticProfession);
      myMadLibs.Country(country);
      myMadLibs.AnotherSillyName(anotherSillyName);
      myMadLibs.Color(color);
      myMadLibs.Adjective(adjective);
      return View(myMadLibs);
    }



  }
}
