//
// HibernateGenericDao.cs
//
// Created by Sehwan Noh on 4/19/2013.
//

using System.Collections.Generic;
using NHibernate;
using Common.Logging;

namespace DemoApp.Dao.NHibernate
{
    public class HibernateGenericDao<TEntity, TId> : IGenericDao<TEntity, TId> where TEntity : class
    {
        protected static readonly ILog log = LogManager.GetLogger(typeof(HibernateGenericDao<TEntity, TId>));

        private ISessionFactory sessionFactory;

        public ISessionFactory SessionFactory
        {
            protected get { return sessionFactory; }
            set { sessionFactory = value; }
        }

        protected ISession CurrentSession
        {
            get { return sessionFactory.GetCurrentSession(); }
        }

        public TEntity Get(TId id)
        {
            return CurrentSession.Get<TEntity>(id);
        }

        public IList<TEntity> GetAll()
        {
            ICriteria criteria = CurrentSession.CreateCriteria(typeof(TEntity));
            return criteria.List<TEntity>();
        }

        public TEntity Save(TEntity entity)
        {
            try
            {
                CurrentSession.SaveOrUpdate(entity);
                CurrentSession.Flush();
                return entity;
            }
            catch (NonUniqueObjectException)
            {
                return CurrentSession.Merge(entity);
            }
        }

        public void Delete(TId id)
        {
            TEntity entity = Get(id);
            if (entity != null)
            {
                CurrentSession.Delete(entity);
                CurrentSession.Flush();
            }
        }

        public void Delete(TEntity entity)
        {
            CurrentSession.Delete(entity);
            CurrentSession.Flush();
        }
    }
}