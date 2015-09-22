using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Dingyzh.Demo.WebApi.Common
{
    /// <summary>    /// <summary>
    /// 签名帮助类
    /// </summary>
    public static class SecuritySignHelper
    {
        public const string PartnerId = "partner_id";
        public const string ApiSign = "api_sign";
        /// <summary>
        /// 获取防篡改签名，组织原始字符串的方式为：先get后post，该签名要求partner在加密时为全小写，同时该方法隐含要求parnter和sign必须通过QueryString方式传递
        /// </summary>
        /// <param name="getCollection">通过QueryString方式传递的键值集合,如果内部包含parnter或者sign，相关字段在组织原始字符串时将会被移除</param>
        /// <param name="partnerId">合作账号</param>
        /// <param name="parterKey">合作Key</param>
        /// <param name="postCollection">通过form方式传递的字符串，如果包含app_id或者api_sign，此部分不会被做特殊处理</param>
        /// <returns></returns>
        public static string GetSecuritySign(this NameValueCollection getCollection, string partnerId, string parterKey, NameValueCollection postCollection = null)
        {
            if (string.IsNullOrWhiteSpace(partnerId) || string.IsNullOrWhiteSpace(parterKey))
            {
                throw new ArgumentNullException();
            }
            var dic = SecuritySignHelper.GetSortedDictionary(getCollection,
                (k) =>
                {//过滤partner及sign
                    return string.Equals(k, SecuritySignHelper.PartnerId, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(k, SecuritySignHelper.ApiSign, StringComparison.OrdinalIgnoreCase);
                });
            dic.Add(SecuritySignHelper.PartnerId, partnerId);
            StringBuilder builder = new StringBuilder();
            SecuritySignHelper.FillStringBuilder(builder, dic);//将QueryString填入StringBuilder


            dic = SecuritySignHelper.GetSortedDictionary(postCollection);
            SecuritySignHelper.FillStringBuilder(builder, dic);//将Form填入StringBuilder

            builder.AppendFormat("{0}{1}", "&", parterKey);//在尾部添加key

            return builder.ToString().GetMD5_32();//获取32位长度的Md5摘要
        }
        public static SortedDictionary<string, string> GetSortedDictionary(NameValueCollection collection, Func<string, bool> filter = null)
        {//获取排序的键值对
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            if (collection != null && collection.Count > 0)
            {
                foreach (var k in collection.AllKeys)
                {
                    if (filter == null || !filter(k))
                    {//如果没设置过滤条件或者无需过滤
                        dic.Add(k, collection[k]);
                    }
                }
            }
            return dic;
        }
        public static void FillStringBuilder(StringBuilder builder, SortedDictionary<string, string> dic)
        {
            foreach (var kv in dic)
            {
                if (builder.Length != 0)
                { builder.Append("&"); }
                builder.Append(kv.Key);
                builder.Append('=');
                builder.Append(kv.Value);
            }//按key顺序组织字符串
        }

        /// <summary>
        /// 获取32位长度的Md5摘要
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string GetMD5_32(this string inputStr, Encoding encoding = null)
        {
            RefEncoding(ref encoding);
            byte[] data = GetMD5(inputStr, encoding);
            StringBuilder tmp = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                tmp.Append(data[i].ToString("x2"));
            }
            return tmp.ToString();
        }
        private static byte[] GetMD5(string inputStr, Encoding encoding)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return md5Hash.ComputeHash(encoding.GetBytes(inputStr));
            }
        }
        private static void RefEncoding(ref Encoding encoding)
        {
            if (encoding == null)
            {
                //encoding = Encoding.Default;
                encoding = Encoding.UTF8;
            }
        }
    }
}