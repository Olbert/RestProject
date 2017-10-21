using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using Npgsql;
using NpgsqlTypes;
using Newtonsoft.Json.Linq;
using Rest_v5.Services;
using Rest_v5.Repositories;
namespace Rest_v5.Controllers
{
    [Route("api")]
    public class ValuesController : Controller
    {

        // GET api/Table
        [HttpGet("{table}")]
        public JsonResult Get(string table)
        {
            try
            {
                try
                {
                    var Rep = (IRepository<Rest_v5.Models.Order>)UrlParser.GetRepository(table);
                }
                catch (Exception)
                {
                    Object
                    throw;
                }
                
                
               // MarketContext MC = new MarketContext();
               
                return Json(Rep.GetList());
               // MC.CreateConnection(); 
                //ACProducts2.GetList();
                //if (MC.Connected())
                 //   return Json(уоMC.Select(table));
                //else
                   // throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }

        // GET api/Table/5
        [HttpGet("{table}/{id:int}")]
        public JsonResult Get(string table, int id)
        {
            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Select(table, id));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }

        // GET api/Table/5
        [HttpGet("{table}/filter={filter}")]
        public JsonResult Get(string table, string filter)
        {
            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Select(table, filter));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }


        // POST api/Table
        [HttpPost("{table}")]
        public JsonResult Post(string table, [FromBody] JObject parameters)
        {
            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Insert(table, parameters));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }

        // PUT api/Table/5
        [HttpPut("{table}/{id:int}")]
        public JsonResult Put(string table, int id, [FromBody]JObject parameters)
        {
            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Update(table, id, parameters));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }

        // PUT api/Table
        [HttpPut("{table}")]
        public JsonResult Put(string table, [FromBody]JObject parameters)
        {

            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Update(table, parameters));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }

        // DELETE api/Table/5
        [HttpDelete("{table}/{id:int}")]
        public JsonResult Delete(string table, int id)
        {
            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Delete(table, id));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }

        [HttpDelete("{table}/filter={filter}")]
        public JsonResult Delete(string table, string filter)
        {
            string FullTable = "public." + '"' + table + '"';
            try
            {
                MarketContext MC = new MarketContext();
                MC.CreateConnection();
                if (MC.Connected())
                    return Json(MC.Delete(FullTable, filter));
                else
                    throw new Exception("Connection failed");
            }
            catch (Exception ex)
            {
                return Json("Error: " + ex.Message);
            }
        }
    }
}
