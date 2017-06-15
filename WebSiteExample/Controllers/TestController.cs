using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebSiteExample.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Delete(int id)
        {
            Console.WriteLine("");
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }

    // DELETE: /User/Delete
    //[HttpDelete]
    //public JsonResult Delete(int id)
    //{
    //    return Json("Response from Delete");
    //}
}
