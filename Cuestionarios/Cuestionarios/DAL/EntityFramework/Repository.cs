﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Cuestionarios.DAL.EntityFramework
{
    abstract class Repository<TEntity, TDbContext>: IRepository<TEntity>
        where TEntity: class
        where TDbContext: DbContext
    {
        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pContext)
        {
            try
            {
                iDbContext = pContext;
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }
        }

        /// <summary>
        /// Adds an entity
        /// </summary>
        public void Add(TEntity pEntity)
        {
            try
            {
                iDbContext.Set<TEntity>().Add(pEntity);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

        }

        /// <summary>
        /// Gets the entity by its id
        /// </summary>
        public TEntity GetByID(int pId)
        {
            try
            {
                return iDbContext.Set<TEntity>().Find(pId);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

        }

        /// <summary>
        /// Gets all entities
        /// </summary>
        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return iDbContext.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

        }


        /// <summary>
        /// Remove an entity
        /// </summary>
        public void Remove(TEntity pEntity)
        {
            try
            {
                iDbContext.Set<TEntity>().Remove(pEntity);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }

        }
    }
}
