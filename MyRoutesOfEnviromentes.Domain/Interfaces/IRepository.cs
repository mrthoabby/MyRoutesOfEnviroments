﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Interfaces

{
    public interface IRepository<TEntity,TEntityId> : IAdd<TEntity>,IDelete<TEntityId>,IEdit<TEntity>,IGet<TEntity,TEntityId>
    {
    }
}
