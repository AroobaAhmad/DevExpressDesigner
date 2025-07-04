using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers
{
  

    public class DevExpressDesignerController : Controller
    {
        public IActionResult Designer(string reportId)
        {
            ViewBag.ReportName = "EurotracsCleaningDocumentReport";
            return View(); 
        }
    }

}
