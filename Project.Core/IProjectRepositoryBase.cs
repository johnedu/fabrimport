using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project
{
    public interface IProjectRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        Task<IQueryable<TEntity>> GetByPropertiesAsync(List<Tuple<string, object, string>> properties);
    }
}