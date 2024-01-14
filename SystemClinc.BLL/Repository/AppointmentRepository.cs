using Clinic_Registration_and_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc.BLL.Repository
{
    internal class AppointmentRepository : GenaricRepository<Appointment>, IAppointment
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
