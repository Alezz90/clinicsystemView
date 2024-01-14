using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class AppointmentController : Controller
    { 
        private readonly Appointment _Appointment;
        public AppointmentController(Appointment appointment) {
            _Appointment = appointment;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
