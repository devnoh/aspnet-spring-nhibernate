using DemoApp.Dao;
using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Dao.NHibernate
{
    public class HibernateDeptDao : HibernateGenericDao<Dept, int>, IDeptDao
    {
    }
}