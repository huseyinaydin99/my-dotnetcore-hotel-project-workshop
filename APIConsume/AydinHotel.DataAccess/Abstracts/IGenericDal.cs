using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.Entity.Abstracts;

namespace AydinHotel.DataAccess.Abstracts
{
    public interface IGenericDal<T> where T : class, IEntity, new()
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
    }
}
