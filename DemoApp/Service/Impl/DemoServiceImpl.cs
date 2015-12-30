using Common.Logging;
using DemoApp.Dao;
using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;

namespace DemoApp.Service.Impl
{
    public class DemoServiceImpl : IDemoService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DemoServiceImpl));

        public IDeptDao DeptDao { get; set; }
        public IEmpDao EmpDao { get; set; }

        //
        // Dept
        //

        public Dept SaveDept(Dept dept)
        {
            return DeptDao.Save(dept);
        }

        public void DeleteDept(int deptNo)
        {
            DeptDao.Delete(deptNo);
        }

        public Dept GetDept(int deptNo)
        {
            return DeptDao.Get(deptNo);
        }

        public IList<Dept> GetAllDepts()
        {
            return DeptDao.GetAll();
        }

        //
        // Emp
        //
        public Emp SaveEmp(Emp emp)
        {
            return EmpDao.Save(emp);
        }

        public void DeleteEmp(int empNo)
        {
            EmpDao.Delete(empNo);
        }

        public Emp GetEmp(int empNo)
        {
            return EmpDao.Get(empNo);
        }

        public IList<Emp> GetAllEmps()
        {
            return EmpDao.GetAll();
        }

        public IList<Emp> GetEmpsByDeptNo(int deptNo)
        {
            return EmpDao.GetEmpsByDeptNo(deptNo);
        }
    }
}
