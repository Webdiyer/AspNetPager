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
            System.Diagnostics.Process.Start("http://en.webdiyer.com");
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label1.Text="Version "+ Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
