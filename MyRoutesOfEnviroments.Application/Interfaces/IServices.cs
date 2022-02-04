using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRoutesOfEnviromentes.Domain.Interfaces;
namespace MyRoutesOfEnviroments.Application.Interfaces
{
    public interface IServices<TEntity,TEntityId> : IAdd<TEntity>,IDelete<TEntityId>,IEdit<TEntity>,IGet<TEntity,TEntityId>
    {
    }
}
