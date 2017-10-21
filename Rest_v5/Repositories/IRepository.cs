using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest_v5.Models;
namespace Rest_v5.Repositories
{

    public interface IIRepository : IDisposable
    { }
    public interface IRepository<Model> : IDisposable, IIRepository
    {
        IEnumerable<Model> GetList(); // получение всех объектов
        Model Get(int id); // получение одного объекта по id
        void Create(Model item); // создание объекта
        void Update(Model item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }

}
