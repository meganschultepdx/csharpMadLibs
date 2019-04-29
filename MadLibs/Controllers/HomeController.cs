using Microsoft.AspNetCore.Mvc;
using MadLibsStory.Models;

namespace MadLibsStory.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madLibs")]
    public ActionResult Story(string sillyName, string unrealisticProfession, string country, string anotherSillyName, string color, string adjective)
    {
      MadLibs myMadLibs = new MadLibs();
      myMadLibs.SetSillyName(sillyName);
      myMadLibs.SetUnrealisticProfession(unrealisticProfession);
      myMadLibs.SetCountry(country);
      myMadLibs.SetAnotherSillyName(anotherSillyName);
      myMadLibs.SetColor(color);
      myMadLibs.SetAdjective(adjective);
      return View(myMadLibs);
    }



  }
}
