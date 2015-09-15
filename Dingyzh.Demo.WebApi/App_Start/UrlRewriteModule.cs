using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Dingyzh.Demo.WebApi.App_Start
{
    public class UrlRewriteModule : IHttpModule
    {
        /// <summary>
        /// 您将需要在网站的 Web.config 文件中配置此模块
        /// 并向 IIS 注册它，然后才能使用它。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //此处放置清除代码。
        }

        public void Init(HttpApplication context)
        {
            context.AuthorizeRequest += Context_AuthorizeRequest;
            // 下面是如何处理 LogRequest 事件并为其 
            // 提供自定义日志记录实现的示例
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        private void Context_AuthorizeRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            if (app.Request.Path.StartsWith("/api/test"))
                this.Rewrite(app);
            //app.Request.RequestContext.HttpContext.RewritePath()
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //可以在此处放置自定义日志记录逻辑
        }

        private void Rewrite(HttpApplication app)
        {
            NameValueCollection getCollection = app.Request.QueryString;
            NameValueCollection postCollection = app.Request.Form;

            //var client_time = getCollection["client_time"];
            //var api_sign = getCollection["api_sign"];
            //var app_id = getCollection["app_id"];
            //var debug = getCollection["debug"];

            var action = getCollection["action"];
            var ver = getCollection["ver"];

            var destDic = this.GetSortedDictionary(getCollection, (k) =>
            {
                return string.Equals(k, "action", StringComparison.OrdinalIgnoreCase) || string.Equals(k, "ver", StringComparison.OrdinalIgnoreCase);
            });
            StringBuilder builder = new StringBuilder();
            this.FillStringBuilder(builder, destDic);
            //builder.Remove(0, 1);

            var destPath = string.Format("{0}/{1}/{2}?{3}", "/iapi/test", action, ver, builder.ToString());
            app.Request.RequestContext.HttpContext.RewritePath(destPath,true);
        }

        private SortedDictionary<string, string> GetSortedDictionary(NameValueCollection collection, Func<string, bool> filter)
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            if (collection != null && collection.Count > 0)
            {
                foreach (var k in collection.AllKeys)
                {
                    if (filter == null || !filter(k))
                    {
                        dic.Add(k, collection[k]);
                    }
                }
            }
            return dic;
        }

        private void FillStringBuilder(StringBuilder builder, SortedDictionary<string, string> dic)
        {
            foreach (var kv in dic)
            {
                if (builder.Length != 0)
                { builder.Append("&"); }
                builder.Append(kv.Key);
                builder.Append("=");
                builder.Append(kv.Value);
            }
        }
    }
}
