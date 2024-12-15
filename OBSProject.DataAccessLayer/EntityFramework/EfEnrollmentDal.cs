using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DataAccessLayer.Concrete;
using OBSProject.DataAccessLayer.Context;
using OBSProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.DataAccessLayer.EntityFramework
{
    public class EfEnrollmentDal : GenericRepository<Enrollment>, IEnrollmentDal
    {
        public EfEnrollmentDal(OBSProjectDbContext context) : base(context)
        {
        }
    }
}
