using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Application.Interfaces
{
    public interface IRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {
        
    }

    public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class{

    }
}