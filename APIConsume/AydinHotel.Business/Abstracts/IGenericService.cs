using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.Entity.Abstracts;

namespace AydinHotel.Business.Abstracts
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        void TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        List<T> TGetList();
        T TGetById(int id);
    }
}
