using MyRoutesOfEnviromentes.Domain.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Interfaces
{
    public interface IDelete<TEntityId>
    {
        Task<OperationResult> DeleteAsync(TEntityId idEntity);
    }
}
