using Microsoft.AspNetCore.Mvc;
using MadLibsStory.Models;

namespace MadLibsStory.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string sillyName, string unrealisticProfession, string country, string anotherSillyName, string color, string adjective, string verb)
    {
      MadLibs myMadLibs = new MadLibs();
      myMadLibs.SetSillyName(sillyName);
      myMadLibs.SetUnrealisticProfession(unrealisticProfession);
      myMadLibs.SetCountry(country);
      myMadLibs.SetAnotherSillyName(anotherSillyName);
      myMadLibs.SetColor(color);
      myMadLibs.SetAdjective(adjective);
      myMadLibs.SetVerb(verb);
      return View(myMadLibs);
    }



  }
}
