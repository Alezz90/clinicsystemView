using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemClinc.BLL.Repository
{
    internal class SpecializationRepository : GenaricRepository<Specialization>, ISpecializationRepository
    {
        private readonly ApplicationDbContext _context;

        public SpecializationRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
