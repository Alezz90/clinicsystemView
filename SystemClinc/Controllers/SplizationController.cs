using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class SplizationController : Controller
    {
        private readonly ISplization _splization;
        public SplizationController(ISplization splization)
        {
            _splization = splization;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
