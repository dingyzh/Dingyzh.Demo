using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dingyzh.Demo.WebApi.Controllers
{
    [RoutePrefix("iapi/test")]
    public class TestController : ApiController
    {
        [Route("get/v1")]
        public string Get(string id)
        {
            return string.Format("Get:{0}", id);
        } 
    }
}
