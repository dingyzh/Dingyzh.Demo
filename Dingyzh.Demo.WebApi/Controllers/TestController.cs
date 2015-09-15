using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dingyzh.Demo.WebApi.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [Route("get/v1")]
        public string Get(string id)
        {
            return string.Format("Get:{0}", id);
        }

        /// <summary>
        /// 当从Body中获取Form参数时，需要对对象进行封装
        /// http://localhost:45899/api/test/post/v1
        /// body id=1&name=2
        /// Header Content-Type=application/x-www-form-urlencoded
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("post/v1")]
        public string Post([FromBody]PostParametersDto dto)
        {
            return string.Format("Post.id:{0},name:{1}", dto.Id, dto.Name);
            return string.Format("Post.");
        }
    }

    public class PostParametersDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
