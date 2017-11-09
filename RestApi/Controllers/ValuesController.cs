using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestApi.Models;

namespace RestApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get(string input)
        {
            //return Ok(new string[] { "value1", "value2" });
            return Ok(new ValuesModel {ValueString = input});
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post(ValuesModel input)
        {
            return Ok(new ValuesModel {ValueString = "PostValue: "+input.ValueString});
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
