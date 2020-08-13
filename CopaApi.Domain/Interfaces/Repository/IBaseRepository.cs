using CopaApi.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaApi.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> : IBaseService<TEntity> where TEntity : class
    {

    }
}
