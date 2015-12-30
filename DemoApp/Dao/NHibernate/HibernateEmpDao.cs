using DemoApp.Dao;
using DemoApp.Models;
using NHibernate;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Dao.NHibernate
{
    public class HibernateEmpDao : HibernateGenericDao<Emp, int>, IEmpDao
    {
        public IList<Emp> GetEmpsByDeptNo(int deptNo)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select a from Emp a ");
            builder.Append("where a.Dept.DeptNo=:deptNo ");
            builder.Append("order by a.EName asc ");
            IQuery query = CurrentSession.CreateQuery(builder.ToString());
            query.SetParameter("deptNo", deptNo);
            return query.List<Emp>();
        }
    }
}