﻿using BusinessLayer.Abstract;
using DataAccesslayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void TDelete(Job t)
        {
            _jobDal.Delete(t);
        }

        public Job TGetById(int Id)
        {
            return _jobDal.GetById(Id);
        }

        public List<Job> TGetList()
        {
            return _jobDal.GetList();
        }

        public void TInsert(Job t)
        {
            _jobDal.Insert(t);
        }

        public void TUpdate(Job t)
        {
            _jobDal.Update(t);
        }
    }
}
