using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest_v5.Repositories;
using Rest_v5.Models;
namespace Rest_v5.Services
{
    /*
    url parser - service 
    IUrlParser в контроллере

    Метод определяет к какому ресурсу/методу соответствует запрос

    В нём все репозитории
*/


    public static class UrlParser
    {

        public static  IRepository<Model> GetRepository(string Url)
        {
            switch (Url)
            {
                case "Category":
                    return new PostgresCategoryRepository();
                case "Order":
                    return new PostgresOrderRepository();
                case "Product":
                    return new PostgresProductRepository();
                case "Product_Order":
                    return new PostgresProduct_OrderRepository();
                case "User":
                    return new PostgresUserRepository();
                default:
                    throw new Exception();
            }
        }
    }
}
