using System.Web.Mvc;

namespace NonCompiledMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View((object)"It Works!");
        }
    }
}