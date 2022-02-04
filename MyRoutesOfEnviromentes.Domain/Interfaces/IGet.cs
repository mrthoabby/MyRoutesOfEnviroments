using MyRoutesOfEnviromentes.Domain.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Interfaces
{
    public interface IGet<TEntity, TEntityId>
    {
       Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(TEntityId idEntity); 
    }
}
