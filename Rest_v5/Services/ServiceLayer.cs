using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Npgsql.EntityFrameworkCore;
using Rest_v5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using Rest_v5.Repositories;
// REDO
namespace Rest_v5.Services
{


    public class MarketContext : DbContext
    {
        public MarketContext()
        //   : base("MarketDatabase")
        {
            ProviderName = "PostgreSQL"; //ConfigurationManager.AppSettings["ProviderName"];
            Host = "localhost";//ConfigurationManager.AppSettings["Host"];
            Port = 5432;//Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);

            DataBase = "AC_Market2";//ConfigurationManager.AppSettings["DataBase"];       
            Schema = "public";// ConfigurationManager.AppSettings["Schema"];

            User = "postgres";//ConfigurationManager.AppSettings["UserName"];
            Password = "1234";// ConfigurationManager.AppSettings["Password"];

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Order> ProductOrders { get; set; }
        public DbSet<User> Users { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(GetConnectionString());
        }

        public string ProviderName { get; set; }

        public string Host { get; set; }
        public int Port { get; set; } 
        public string DataBase { get; set; }
        public string Schema { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        NpgsqlConnection BaseConnection;

        public string GetConnectionString()
        {
            return "Server=" + Host + ";Port=" + Port + ";User Id=" + User + ";Password=" + Password + ";Database=" + DataBase + ";";
        }
        
        public bool Connected()
        {

            NpgsqlConnection BaseConnection = new NpgsqlConnection(GetConnectionString());
            try
            {
                BaseConnection.Open();
                BaseConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                BaseConnection.Dispose();
            }
        }


        public NpgsqlConnection CreateConnection()
        {
            BaseConnection = new NpgsqlConnection(GetConnectionString());
            try
            {
                BaseConnection.Open();
                return BaseConnection;
            }
            catch (Exception ex)
            {
                BaseConnection.Dispose();
                return null;
            }
        }
        public List<Dictionary<string, object>> Select(string table)
        {
            // SelectCommand command = new SelectCommand(BaseConnection, table);
            //  return command.Execute();
            return new List<Dictionary<string, object>>();
        }
        public List<Dictionary<string, object>> Select(string table, int id)
        {
            //  SelectCommand command = new SelectCommand(BaseConnection, table, "id = " + id);
            //  return command.Execute();
            return new List<Dictionary<string, object>>();

        }

        public List<Dictionary<string, object>> Select(string table, string filter)
        {
            //   SelectCommand command = new SelectCommand(BaseConnection, table, filter);
            // return command.Execute();
            return new List<Dictionary<string, object>>();

        }
        public List<Dictionary<string, object>> Insert(string table, JObject id)
        {
            //SelectCommand command = new SelectCommand(BaseConnection, table, "id = " + id);
            //return command.Execute();
            return new List<Dictionary<string, object>>();

        }
        public int Insert(string table, Microsoft.EntityFrameworkCore.Metadata.Internal.Model model)
        {
            //InsertCommand command = new InsertCommand(BaseConnection, table, model.GetColumns(), ToSQLType.Convert(model.GetValues()));
            //return command.Execute();
            return 0;
        }
        public int Update(string table, JObject model)
        {
            //Parse Model
            //UpdateCommand command = new UpdateCommand(BaseConnection, table, model.GetColumns(), ToSQLType.Convert(model.GetValues()).Cast<string>().ToArray());
            //return command.Execute();
            return 0;
        }
        public int Update(string table, int id, JObject model)
        {
            //Parse Model
            //UpdateCommand command = new UpdateCommand(BaseConnection, table, model.GetColumns(), ToSQLType.Convert(model.GetValues()).Cast<string>().ToArray(), " id = " + id);
            //return command.Execute();
            return 0;
        }
        public int Delete(string table)
        {
            //DeleteCommand command = new DeleteCommand(BaseConnection, table);
            //return command.Execute();

            return 0;
        }
        public int Delete(string table, string filter)
        {
            //DeleteCommand command = new DeleteCommand(BaseConnection, table, filter);
            //return command.Execute();
            return 0;
        }
        public int Delete(string table, int id)
        {
            //DeleteCommand command = new DeleteCommand(BaseConnection, table, "id = " + id);
            //return command.Execute();
            return 0;
        }

    }
    /*
    public class DataBaseContext : DbContext
    {
        public string ProviderName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string DataBase { get; set; }
        public string Schema { get; set; }
        public string User { get; set; }
        public string Password { get; set; }



        public DbSet<Client> Clients { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Order> Orders { get; set; }



        public DataBaseContext()
        {
            ProviderName = "PostgreSQL"; //ConfigurationManager.AppSettings["ProviderName"];
            Host = "localhost";//ConfigurationManager.AppSettings["Host"];
            Port = 5432;//Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);

            DataBase = "BookingBase";//ConfigurationManager.AppSettings["DataBase"];       
            Schema = "public";// ConfigurationManager.AppSettings["Schema"];

            User = "postgres";//ConfigurationManager.AppSettings["UserName"];
            Password = "1234";// ConfigurationManager.AppSettings["Password"];

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
        public string GetConnectionString()
        {
            return "Server=" + Host + ";Port=" + Port + ";User Id=" + User + ";Password=" + Password + ";Database=" + DataBase + ";";
        }

    
    }
 */   
}