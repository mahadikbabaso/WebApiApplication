using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public List<EmployeeDetatils> Get()
        {

            List<EmployeeDetatils> ObjEmp = new List<EmployeeDetatils>()

                {
                //Adding records to list    
                new EmployeeDetatils { Id=1,Name="Vithal Wadje",City="Latur",Address="Kabansangvi" },
                    new EmployeeDetatils {Id=2,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                     new EmployeeDetatils {Id=3,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                      new EmployeeDetatils {Id=4,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                       new EmployeeDetatils {Id=5,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" }
                };

         
            return ObjEmp;


        }

        // GET api/values/5
        [HttpGet]
        public string GetName(int id)
        {
            List<EmployeeDetatils> ObjEmp = new List<EmployeeDetatils>()

                {
                //Adding records to list    
                new EmployeeDetatils { Id=1,Name="Vithal Wadje",City="Latur",Address="Kabansangvi" },
                    new EmployeeDetatils {Id=2,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                     new EmployeeDetatils {Id=3,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                      new EmployeeDetatils {Id=4,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" },
                       new EmployeeDetatils {Id=5,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" }
                };


            var name = ObjEmp.Where(s => s.Id == id).FirstOrDefault().Name;

            return name;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
