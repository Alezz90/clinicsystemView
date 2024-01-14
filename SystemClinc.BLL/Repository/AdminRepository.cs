using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;

namespace SystemClinc.BLL.Repository
{
    internal class AdminRepository : GenaricRepository<Admin>, IAdmin
    {
        public AdminRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
