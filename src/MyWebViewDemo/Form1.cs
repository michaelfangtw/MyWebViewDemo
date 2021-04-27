using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace MyWebViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialBrowser1();
            InitialBrowser2();
        }
        private WebView2 webview21;
        private WebView2 webview22;
        void InitialBrowser1()
        {
            panel1.Height = 40;

            var url1 = "https://www.udn.com";
            webview21 = new WebView2();
            this.webview21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
            webview21.CreationProperties = null;
            webview21.DefaultBackgroundColor = System.Drawing.Color.White;
            webview21.Location = new System.Drawing.Point(0, panel1.Height);
            webview21.Size = new System.Drawing.Size(splitContainer1.Panel1.Width, this.splitContainer1.Panel1.Height-panel1.Height);
            webview21.TabIndex = 3;
            webview21.ZoomFactor = 1D;
            webview21.Name = "webview21";
            webview21.Source = new Uri(url1);            
            this.splitContainer1.Panel1.Controls.Add(this.webview21);
        }

        void InitialBrowser2()
        {
           
            var url2 = "https://www.ltn.com.tw/";
            webview22 = new WebView2();
            this.webview22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
            webview22.CreationProperties = null;
            webview22.DefaultBackgroundColor = System.Drawing.Color.White;
            webview22.Location = new System.Drawing.Point(0, panel1.Height);
            webview22.Size = new System.Drawing.Size(splitContainer1.Panel2.Width, this.splitContainer1.Panel2.Height - panel2.Height);
            webview22.TabIndex = 3;
            webview22.ZoomFactor = 1D;
            webview22.Name = "webview22";
            webview22.Source = new Uri(url2);

            this.splitContainer1.Panel2.Controls.Add(this.webview22);           
        }

        async void InitializeAsync()
        {
            await webview21.EnsureCoreWebView2Async(null);            
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            webview21.Visible = false;
            webview21.Dispose();
            this.splitContainer1.Panel1.Controls.RemoveByKey("webview21");
            InitialBrowser1();
        }

        private void btnReload2_Click(object sender, EventArgs e)
        {
            webview22.Visible = false;
            webview22.Dispose();
            this.splitContainer1.Panel1.Controls.RemoveByKey("webview22");
            InitialBrowser2();
        }

        private bool top;

        private void panel1_Click(object sender, EventArgs e)
        {
            if ((this.splitContainer1.Tag==null)||(this.splitContainer1.Tag.ToString()=="2"))
            {
                SwitchPanel("1");
                this.splitContainer1.Tag = "1";
            }
            else
            {
                SwitchPanel("2");
                this.splitContainer1.Tag = "2";
            }
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if ((this.splitContainer1.Tag == null) || (this.splitContainer1.Tag.ToString() == "1"))
            {
                SwitchPanel("2");
                this.splitContainer1.Tag = "2";
            }
            else
            {
                SwitchPanel("1");
                this.splitContainer1.Tag = "1";
            }

        }

        void SwitchPanel(string index)
        {
            if (index == "1")
            {

                this.splitContainer1.SplitterDistance = this.splitContainer1.Height - 20;
            }
            else
            {
                this.splitContainer1.SplitterDistance = panel1.Height;
            }
            
        }
    }
}
