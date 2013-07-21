using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wuqi.Webdiyer
{
    public partial class CustomInfoForm : Form
    {
        string customInfoHtml;
        ShowCustomInfoSection showCustomSection;

        public ShowCustomInfoSection ShowCustomSection
        {
            get { return showCustomSection; }
            set { showCustomSection = value; }
        }

        public string CustomInfoHtml
        {
            get { return customInfoHtml; }
            set { customInfoHtml = value; }
        }

        public CustomInfoForm(ShowCustomInfoSection showSection, string customInfo)
        {
            InitializeComponent();
            showCustomSection = showSection;
            CustomInfoHtml = customInfo;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    tb_propvalue.Text = "Page %CurrentPageIndex% of %PageCount%";
                    lbl_preview.Text = "Page 1 of 23";
                    break;
                case 1:
                    tb_propvalue.Text = "共%PageCount%页，当前为第%CurrentPageIndex%页";
                    lbl_preview.Text = "共23页，当前为第1页";
                    break;
                case 2:
                    tb_propvalue.Text = "共%PageCount%页，当前为第%CurrentPageIndex%页，每页%PageSize%条";
                    lbl_preview.Text = "共23页，当前为第1页，每页10条";
                    break;
                case 3:
                    tb_propvalue.Text = "第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条";
                    lbl_preview.Text = "第1页，共23页，每页10条";
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            customInfoHtml = tb_propvalue.Text;
            if (rb_never.Checked)
                showCustomSection = ShowCustomInfoSection.Never;
            else if (rb_left.Checked)
                showCustomSection = ShowCustomInfoSection.Left;
            else
                showCustomSection = ShowCustomInfoSection.Right;
        }

        private void CustomInfoForm_Load(object sender, EventArgs e)
        {
            switch (showCustomSection)
            {
                case ShowCustomInfoSection.Never:
                    listBox1.Enabled = tb_propvalue.Enabled = false;
                    rb_never.Checked = true;
                    break;
                case ShowCustomInfoSection.Left:
                    listBox1.Enabled = tb_propvalue.Enabled = true;
                    rb_left.Checked = true;
                    break;
                default:
                    listBox1.Enabled = tb_propvalue.Enabled = true;
                    rb_right.Checked = true;
                    break;
            }
            tb_propvalue.Text = customInfoHtml;
        }

        private void CustomInfoChanged(object sender, EventArgs e)
        {
            listBox1.Enabled = tb_propvalue.Enabled = !rb_never.Checked;
        }
    }
}
