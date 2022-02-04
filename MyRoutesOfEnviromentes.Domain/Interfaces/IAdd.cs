using MyRoutesOfEnviromentes.Domain.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Interfaces
{
    /// <summary>
    /// The add Interface to add a new Entity
    /// </summary>
    public interface IAdd<TEntity>
    {
        /// <summary>
        /// Adds the Entity to the data base
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>An OperationResult.</returns>
        Task<OperationResult> AddAsync(TEntity entity);
    }
}
