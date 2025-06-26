using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers
{
  

    public class DevExpressDesignerController : Controller
    {
        public IActionResult Designer(string reportId)
        {
            ViewBag.ReportName = reportId;
            return View(); // <-- If this View() is redirecting, we have a problem
        }
    }

}
