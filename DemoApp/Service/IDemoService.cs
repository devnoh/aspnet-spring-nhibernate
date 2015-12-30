using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Service
{
    public interface IDemoService
    {
        //
        // Dept
        //

        Dept SaveDept(Dept dept);
        void DeleteDept(int deptNo);
        Dept GetDept(int deptNo);
        IList<Dept> GetAllDepts();

        //
        // Emp
        //

        Emp SaveEmp(Emp emp);
        void DeleteEmp(int empNo);
        Emp GetEmp(int empNo);
        IList<Emp> GetAllEmps();
        IList<Emp> GetEmpsByDeptNo(int deptNo);
    }
}
