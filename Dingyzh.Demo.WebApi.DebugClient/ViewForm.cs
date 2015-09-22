using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Net.Http.Headers;

namespace Dingyzh.Demo.WebApi.DebugClient
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NameValueCollection getCollection = this.GetNameValueCollection(this.gvQueryString);
                if (this.rdSignView.Checked)
                {
                    NameValueCollection postCollection = null;
                    if (this.gbForm.Visible)
                    {
                        postCollection = this.GetNameValueCollection(this.gvForm);
                    }

                    this.txtSign.Text = getCollection.GetSecuritySign(this.txtPartner.Text.Trim(), this.txtPartnerKey.Text.Trim(), postCollection);
                }
                this.SetUrlParams(getCollection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.txtSign.Text = string.Empty;
                this.txtUrlParams.Text = string.Empty;
            }
        }
        private void SetUrlParams(NameValueCollection getCollection)
        {
            if (this.rdSignView.Checked)
            {
                try
                {
                    getCollection.Add(SecuritySignHelper.PartnerId, this.txtPartner.Text.Trim());
                }
                catch
                {
                    getCollection[SecuritySignHelper.PartnerId] = this.txtPartner.Text.Trim();
                }
                try
                {
                    getCollection.Add(SecuritySignHelper.ApiSign, this.txtSign.Text.Trim());
                }
                catch
                {
                    getCollection[SecuritySignHelper.ApiSign] = this.txtSign.Text.Trim();
                }
            }
            StringBuilder tmp = new StringBuilder();
            for (int i = 0; i < getCollection.Count; i++)
            {
                tmp.Append('&');
                tmp.Append(getCollection.GetKey(i));
                tmp.Append('=');
                tmp.Append(getCollection[i]);
            }
            tmp.Remove(0, 1);
            this.txtUrlParams.Text = tmp.ToString();
        }

        private NameValueCollection GetNameValueCollection(DataGridView gv)
        {
            NameValueCollection collection = new NameValueCollection();
            var rows = gv.Rows;
            foreach (DataGridViewRow row in rows)
            {
                try
                {
                    if (row.Cells[0].Value != null)
                    {
                        collection.Add(row.Cells[0].Value.ToString(),
                            row.Cells[1].Value == null ? string.Empty : row.Cells[1].Value.ToString());
                    }
                }
                catch { }//忽略异常，不检测是否存在重复的键值
            }
            
            return collection;
        }


        private void btRequest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtUrl.Text))
            {
                this.txtResponse.Text = string.Empty;
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/" + this.cmbResponseContentType.Text.ToLower()));
                Task<HttpResponseMessage> task;
                this.button1_Click(null, null);
                if (!string.IsNullOrWhiteSpace(this.txtUrlParams.Text))
                {
                    string url = string.Format("{0}?{1}", this.txtUrl.Text, this.txtUrlParams.Text);
                    switch (this.cmbMethod.Text)
                    {
                        case "POST":
                        case "PUT":
                            var postCollection = this.GetNameValueCollection(this.gvForm);
                            var dic = new Dictionary<string, string>();
                            for (int i = 0; i < postCollection.Count; i++)
                            {
                                dic.Add(postCollection.GetKey(i), postCollection[i]);
                            }
                            HttpContent httpContent = new FormUrlEncodedContent(dic);
                            //ContentType必须是application/x-www-form-urlencoded，否则服务端接收不到该数据
                            //httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/" + this.cmbContentType.Text.ToLower());
                            if (this.cmbMethod.Text == "POST")
                            {
                                task = httpClient.PostAsync(url, httpContent);
                            }
                            else
                            {
                                task = httpClient.PutAsync(url, httpContent);
                            }
                            break;
                        default:
                            if (this.cmbMethod.Text == "DELETE")
                            {
                                task = httpClient.DeleteAsync(url);
                            }
                            else
                            {
                                task = httpClient.GetAsync(url);
                            }
                            break;
                    }
                    var responseContent = task.Result.Content;
                    this.txtResponse.Text = responseContent.ReadAsStringAsync().Result;
                }
            }
        }

        private void cmbMethod_TextChanged(object sender, EventArgs e)
        {
            string method = this.cmbMethod.Text.ToUpper();
            if (method != "GET" && method != "POST" && method != "PUT" && method != "DELETE")
            {
                this.cmbMethod.Text = "GET";
            }
            else
            {
                this.cmbMethod.Text = method;
            }
            this.gbForm.Visible = this.cmbMethod.Text == "POST" || this.cmbMethod.Text == "PUT";
        }

        private void rdView_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            if (rd != null)
            {
                bool isSignView = rd.Name == "rdSignView";
                this.label1.Visible = isSignView;
                this.label2.Visible = isSignView;
                this.txtPartner.Visible = isSignView;
                this.txtPartnerKey.Visible = isSignView;
                this.button1.Text = isSignView ? "生成签名" : "生成Params";
                this.txtSign.Text = string.Empty;
                this.txtUrlParams.Text = string.Empty;
            }
        }
    }
}
