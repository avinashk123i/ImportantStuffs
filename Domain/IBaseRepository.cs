﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
