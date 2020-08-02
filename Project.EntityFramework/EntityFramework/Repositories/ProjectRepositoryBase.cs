using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Project.EntityFramework.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class ProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProjectRepositoryBase(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<IQueryable<TEntity>> GetByPropertiesAsync(List<Tuple<string, object, string>> properties)
        {
            var predicate = PredicateBuilder.New<TEntity>();
            foreach (var property in properties)
            {
                predicate.And(BuildPredicate(property.Item1, property.Item2, property.Item3));
            }

            return await Task.FromResult(GetAll().AsExpandable().Where(predicate));
        }

        private Expression<Func<TEntity, bool>> BuildPredicate(string key, object value, string operation)
        {
            ParameterExpression param = Expression.Parameter(typeof(TEntity), "p");
            MemberExpression member = Expression.Property(param, key);
            ConstantExpression constant = Expression.Constant(value);
            Expression comparingExpression = default(BinaryExpression);

            switch (operation)
            {
                case ProjectConsts.LAMBDA_EXPRESSION_EQUAL_OPERATOR:
                    comparingExpression = Expression.Equal(member, constant);
                    break;
                case ProjectConsts.LAMBDA_EXPRESSION_NOTEQUAL_OPERATOR:
                    comparingExpression = Expression.NotEqual(member, constant);
                    break;
                default:
                    break;
            }
            return Expression.Lambda<Func<TEntity, bool>>(comparingExpression, param);
        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="ProjectRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class ProjectRepositoryBase<TEntity> : ProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProjectRepositoryBase(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
