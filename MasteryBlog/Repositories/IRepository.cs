﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Repositories
{
    public interface IRepository<T> where T : class 
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);
        void Create(T obj);
        void Edit(T obj);
        void Delete(T obj);

        IEnumerable<T> GetByCategoryID(int id);
        IEnumerable<T> GetByTagID(int id);
    }
}
