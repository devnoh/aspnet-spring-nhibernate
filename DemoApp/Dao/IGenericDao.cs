//
// IGenericDao.cs
//
// Created by Sehwan Noh on 4/19/2013.
//

using System.Collections.Generic;

namespace DemoApp.Dao
{
    public interface IGenericDao<TEntity, TId>
    {
        /// <summary>
        /// Finds entity with given id.
        /// </summary>
        /// <param name="id">The id to search with.</param>
        /// <returns>Found entity or null if not found.</returns>
        TEntity Get(TId id);

        /// <summary>
        /// Returns all entities of given type.
        /// The result may be different than in database based on
        /// filters or other locked search criteria for search.
        /// </summary>
        /// <returns></returns>
        IList<TEntity> GetAll();

        /// <summary>
        /// Saves the given entity.
        /// </summary>
        /// <param name="entity">Entity to save.</param>
        /// <returns>Saved entity with id.</returns>
        TEntity Save(TEntity entity);

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="id">The id to search with.</param>
        void Delete(TId id);

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <returns>Entity with id.</returns>
        void Delete(TEntity entity);
    }
}
