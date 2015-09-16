using Dingyzh.Demo.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Web;

namespace Dingyzh.Demo.WebApi.App_Start
{
    public class TestUrlRewriteModule : IHttpModule
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
            context.BeginRequest += Context_BeginRequest;
            // 下面是如何处理 LogRequest 事件并为其 
            // 提供自定义日志记录实现的示例
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            if (app.Request.Path.StartsWith("/api/test") && app.Request.Headers.Get("Redirected") == null)
            {
                var validateReuslt = this.ValidateSign(app);
                if (validateReuslt)
                {
                    this.Rewrite(app);
                }
            }
        }


        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //可以在此处放置自定义日志记录逻辑
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        private bool ValidateSign(HttpApplication app)
        {
            NameValueCollection getCollection = app.Request.QueryString;
            NameValueCollection postCollection = app.Request.Form;

            var client_time = getCollection["client_time"];
            var api_sign = getCollection["api_sign"];
            var parter_id = getCollection["parter_id"];
            var debug = getCollection["debug"];
            var action = getCollection["action"];
            var ver = getCollection["ver"];

            var parterKey = ParterHelper.GetKey(parter_id);
            var validateSign = SecuritySignHelper.GetSecuritySign(getCollection, parter_id, parterKey, postCollection);
            return api_sign == validateSign;
        }
       
        /// <summary>
        /// 重写url
        /// </summary>
        /// <param name="app"></param>
        private void Rewrite(HttpApplication app)
        {
            NameValueCollection getCollection = app.Request.QueryString;
            var action = getCollection["action"];
            var ver = getCollection["ver"];

            var destDic = SecuritySignHelper.GetSortedDictionary(getCollection, (k) =>
            {
                return string.Equals(k, "action", StringComparison.OrdinalIgnoreCase)
                || string.Equals(k, "ver", StringComparison.OrdinalIgnoreCase)
                || string.Equals(k, "client_time", StringComparison.OrdinalIgnoreCase)
                || string.Equals(k, SecuritySignHelper.ApiSign, StringComparison.OrdinalIgnoreCase)
                || string.Equals(k, SecuritySignHelper.ParterId, StringComparison.OrdinalIgnoreCase);
            });
            StringBuilder builder = new StringBuilder();
            SecuritySignHelper.FillStringBuilder(builder, destDic);


            var destPath = string.Format("{0}/{1}/{2}?{3}", "/api/test", action, ver, builder.ToString());
            app.Request.Headers.Add("Redirected", "true");
            app.Request.RequestContext.HttpContext.RewritePath(destPath, true);
        }

    }
}
