namespace Dingyzh.Demo.WebApi.DebugClient
{
    partial class ViewForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.txtPartnerKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdCommonView = new System.Windows.Forms.RadioButton();
            this.rdSignView = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btRequest = new System.Windows.Forms.Button();
            this.cmbResponseContentType = new System.Windows.Forms.ComboBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.gbQueryString = new System.Windows.Forms.GroupBox();
            this.gvQueryString = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrlParams = new System.Windows.Forms.TextBox();
            this.gbPostContentType = new System.Windows.Forms.GroupBox();
            this.txtPostContentType = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbForm.SuspendLayout();
            this.gbQueryString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQueryString)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbPostContentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partner:";
            // 
            // txtPartner
            // 
            this.txtPartner.Location = new System.Drawing.Point(104, 20);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(117, 21);
            this.txtPartner.TabIndex = 1;
            // 
            // txtPartnerKey
            // 
            this.txtPartnerKey.Location = new System.Drawing.Point(364, 20);
            this.txtPartnerKey.Name = "txtPartnerKey";
            this.txtPartnerKey.Size = new System.Drawing.Size(117, 21);
            this.txtPartnerKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PartnerKey:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdCommonView);
            this.groupBox2.Controls.Add(this.rdSignView);
            this.groupBox2.Controls.Add(this.txtPartner);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPartnerKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户参数";
            // 
            // rdCommonView
            // 
            this.rdCommonView.AutoSize = true;
            this.rdCommonView.Location = new System.Drawing.Point(813, 21);
            this.rdCommonView.Name = "rdCommonView";
            this.rdCommonView.Size = new System.Drawing.Size(71, 16);
            this.rdCommonView.TabIndex = 5;
            this.rdCommonView.Text = "普通访问";
            this.rdCommonView.UseVisualStyleBackColor = true;
            this.rdCommonView.CheckedChanged += new System.EventHandler(this.rdView_CheckedChanged);
            // 
            // rdSignView
            // 
            this.rdSignView.AutoSize = true;
            this.rdSignView.Checked = true;
            this.rdSignView.Location = new System.Drawing.Point(715, 22);
            this.rdSignView.Name = "rdSignView";
            this.rdSignView.Size = new System.Drawing.Size(71, 16);
            this.rdSignView.TabIndex = 4;
            this.rdSignView.TabStop = true;
            this.rdSignView.Text = "签名访问";
            this.rdSignView.UseVisualStyleBackColor = true;
            this.rdSignView.CheckedChanged += new System.EventHandler(this.rdView_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btRequest);
            this.groupBox4.Controls.Add(this.cmbResponseContentType);
            this.groupBox4.Controls.Add(this.cmbMethod);
            this.groupBox4.Controls.Add(this.txtUrl);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtResponse);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(0, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(912, 206);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "访问";
            // 
            // btRequest
            // 
            this.btRequest.Location = new System.Drawing.Point(674, 44);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(75, 23);
            this.btRequest.TabIndex = 23;
            this.btRequest.Text = "访问地址";
            this.btRequest.UseVisualStyleBackColor = true;
            this.btRequest.Click += new System.EventHandler(this.btRequest_Click);
            // 
            // cmbResponseContentType
            // 
            this.cmbResponseContentType.FormattingEnabled = true;
            this.cmbResponseContentType.Items.AddRange(new object[] {
            "JSON",
            "XML"});
            this.cmbResponseContentType.Location = new System.Drawing.Point(378, 46);
            this.cmbResponseContentType.Name = "cmbResponseContentType";
            this.cmbResponseContentType.Size = new System.Drawing.Size(121, 20);
            this.cmbResponseContentType.TabIndex = 22;
            this.cmbResponseContentType.Text = "JSON";
            // 
            // cmbMethod
            // 
            this.cmbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cmbMethod.Location = new System.Drawing.Point(90, 46);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(121, 20);
            this.cmbMethod.TabIndex = 21;
            this.cmbMethod.Text = "GET";
            this.cmbMethod.TextChanged += new System.EventHandler(this.cmbMethod_TextChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(90, 11);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(693, 21);
            this.txtUrl.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Url:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "ResponseContentType:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Method:";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(90, 87);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(693, 110);
            this.txtResponse.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Response:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbPostContentType);
            this.groupBox1.Controls.Add(this.gbForm);
            this.groupBox1.Controls.Add(this.gbQueryString);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 296);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "业务参数";
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.txtPost);
            this.gbForm.Location = new System.Drawing.Point(446, 20);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(454, 208);
            this.gbForm.TabIndex = 2;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Post内容";
            this.gbForm.Visible = false;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(9, 17);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(439, 181);
            this.txtPost.TabIndex = 0;
            // 
            // gbQueryString
            // 
            this.gbQueryString.Controls.Add(this.gvQueryString);
            this.gbQueryString.Location = new System.Drawing.Point(6, 20);
            this.gbQueryString.Name = "gbQueryString";
            this.gbQueryString.Size = new System.Drawing.Size(443, 270);
            this.gbQueryString.TabIndex = 1;
            this.gbQueryString.TabStop = false;
            this.gbQueryString.Text = "QueryString";
            // 
            // gvQueryString
            // 
            this.gvQueryString.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQueryString.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.gvQueryString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvQueryString.Location = new System.Drawing.Point(3, 17);
            this.gvQueryString.Name = "gvQueryString";
            this.gvQueryString.RowTemplate.Height = 23;
            this.gvQueryString.Size = new System.Drawing.Size(437, 250);
            this.gvQueryString.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Key.Width = 135;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 255;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSign);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtUrlParams);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(912, 81);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // txtSign
            // 
            this.txtSign.Location = new System.Drawing.Point(90, 19);
            this.txtSign.Name = "txtSign";
            this.txtSign.ReadOnly = true;
            this.txtSign.Size = new System.Drawing.Size(359, 21);
            this.txtSign.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sign:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "生成签名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "UrlParams:";
            // 
            // txtUrlParams
            // 
            this.txtUrlParams.Location = new System.Drawing.Point(90, 52);
            this.txtUrlParams.Name = "txtUrlParams";
            this.txtUrlParams.ReadOnly = true;
            this.txtUrlParams.Size = new System.Drawing.Size(693, 21);
            this.txtUrlParams.TabIndex = 8;
            // 
            // gbPostContentType
            // 
            this.gbPostContentType.Controls.Add(this.txtPostContentType);
            this.gbPostContentType.Location = new System.Drawing.Point(453, 235);
            this.gbPostContentType.Name = "gbPostContentType";
            this.gbPostContentType.Size = new System.Drawing.Size(441, 52);
            this.gbPostContentType.TabIndex = 3;
            this.gbPostContentType.TabStop = false;
            this.gbPostContentType.Text = "Post内容类型";
            this.gbPostContentType.Visible = false;
            // 
            // txtPostContentType
            // 
            this.txtPostContentType.Location = new System.Drawing.Point(7, 21);
            this.txtPostContentType.Name = "txtPostContentType";
            this.txtPostContentType.Size = new System.Drawing.Size(424, 21);
            this.txtPostContentType.TabIndex = 0;
            this.txtPostContentType.Text = "application/x-www-form-urlencoded";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 638);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewForm";
            this.Text = "WebAPI签名生成工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbQueryString.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvQueryString)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbPostContentType.ResumeLayout(false);
            this.gbPostContentType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.TextBox txtPartnerKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrlParams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.ComboBox cmbResponseContentType;
        private System.Windows.Forms.Button btRequest;
        private System.Windows.Forms.GroupBox gbQueryString;
        private System.Windows.Forms.DataGridView gvQueryString;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.RadioButton rdCommonView;
        private System.Windows.Forms.RadioButton rdSignView;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.GroupBox gbPostContentType;
        private System.Windows.Forms.TextBox txtPostContentType;
    }
}

