using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Dao
{
    public interface IEmpDao : IGenericDao<Emp, int>
    {
        IList<Emp> GetEmpsByDeptNo(int deptNo);

    }
}
