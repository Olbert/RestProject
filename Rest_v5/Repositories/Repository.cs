using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest_v5.Models;
using Rest_v5.Services;
using Microsoft.EntityFrameworkCore;

namespace Rest_v5.Repositories
{

    public partial class PostgresRepository: IRepository<Model>, IDisposable
        {
        protected MarketContext db;

        public PostgresRepository()
        {
            this.db = new MarketContext();
        }

        IEnumerable<Model> IRepository<Model>.GetList()
        {
            throw new NotImplementedException();
        }

        Model IRepository<Model>.Get(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Model>.Create(Model item)
        {
            throw new NotImplementedException();
        }

        public void Update(Model model)//Но это не точно
        {
            db.Entry(model).State = EntityState.Modified;
        }

        void IRepository<Model>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class PostgresCategoryRepository : PostgresRepository, IRepository<Category>, IDisposable
    {

        public PostgresCategoryRepository(): base ()
        {
            this.db = new MarketContext();
        }

        public IEnumerable<Category> GetList()
        {
            return db.Categories;
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public void Create(Category category)
        {
            db.Categories.Add(category);
        }

        public void Update(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Category category = db.Categories.Find(id);
            if (category != null)
                db.Categories.Remove(category);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    public class PostgresUserRepository : IRepository<User>, IDisposable
    {
        private MarketContext db;

        public PostgresUserRepository()
        {
            this.db = new MarketContext();
        }

        public IEnumerable<User> GetList()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    public class PostgresOrderRepository : IRepository<Order>, IDisposable
    {
        private MarketContext db;

        public PostgresOrderRepository()
        {
            this.db = new MarketContext();
        }

        public IEnumerable<Order> GetList()
        {
            return db.Orders;
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public void Create(Order order)
        {
            db.Orders.Add(order);
        }

        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Order order = db.Orders.Find(id);
            if (order != null)
                db.Orders.Remove(order);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


    public class PostgresProduct_OrderRepository : IRepository<Model>, IDisposable
    {
        private MarketContext db;

        public PostgresProduct_OrderRepository()
        {
            this.db = new MarketContext();
        }

        public IEnumerable<Product_Order> GetList()
        {
            return db.ProductOrders;
        }

        public Product_Order Get(int id)
        {
            return db.ProductOrders.Find(id);
        }

        public void Create(Product_Order oroduct_Order)
        {
            db.ProductOrders.Add(oroduct_Order);
        }

        public void Update(Product_Order oroduct_Order)
        {
            db.Entry(oroduct_Order).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product_Order oroduct_Order = db.ProductOrders.Find(id);
            if (oroduct_Order != null)
                db.ProductOrders.Remove(oroduct_Order);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


    public class PostgresProductRepository : IRepository<Product>, IDisposable
    {
        private MarketContext db;

        public PostgresProductRepository()
        {
            this.db = new MarketContext();
        }

        public IEnumerable<Product> GetList()
        {
            return db.Products;
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
        }

        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
                db.Products.Remove(product);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
