using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class AppointmentController : Controller
    { 
        private readonly IAppointment _Appointment;
        private readonly ISpecialization _Special;
        public AppointmentController(IAppointment appointment, ISpecialization special)
        {
            _Appointment = appointment;
            _Special = special;
        }
        public IActionResult Index()
        {
            ViewBag.Special = _Special.GetAll();
            return View();
        }
    }
}
