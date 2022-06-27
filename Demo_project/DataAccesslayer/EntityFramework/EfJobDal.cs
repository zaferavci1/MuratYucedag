using DataAccesslayer.Abstract;
using DataAccesslayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.EntityFramework
{
    public class EfJobDal : GenericRepository<Job>, IJobDal
    {
    }
}
