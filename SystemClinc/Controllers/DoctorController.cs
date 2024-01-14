using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctor _doctor;
        public DoctorController(IDoctor doctor)
        {
            _doctor = doctor;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
