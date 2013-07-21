using System;
using System.Windows.Forms;
using System.Reflection;

namespace Wuqi.Webdiyer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.webdiyer.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dotneturls.com/gb2312");
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label1.Text="控件版本："+ Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
