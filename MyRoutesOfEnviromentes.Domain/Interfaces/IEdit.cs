using MyRoutesOfEnviromentes.Domain.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Interfaces
{
    public interface IEdit<TEntity>
    {
        Task<OperationResult> EditAsync(TEntity entity); 
    }
}
