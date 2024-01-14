using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class PationController : Controller
    {
        private readonly IPation _pation;
        public PationController(IPation pation)
        {
            _pation = pation;
        }
        public IActionResult Index()
        {
            return View();
        }
    }


}
