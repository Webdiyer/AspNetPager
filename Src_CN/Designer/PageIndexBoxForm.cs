using System;
using System.Windows.Forms;

namespace Wuqi.Webdiyer
{
    public partial class PageIndexBoxForm : Form
    {
        ShowPageIndexBox showIndexBox;

        public ShowPageIndexBox ShowIndexBox
        {
            get { return showIndexBox; }
            set { showIndexBox = value; }
        }
        int threshold;

        public int Threshold
        {
            get { return threshold; }
            set { threshold = value; }
        }

        PageIndexBoxType boxType;

        public PageIndexBoxType BoxType
        {
            get { return boxType; }
            set { boxType = value; }
        }

        string textBeforeBox;

        public string TextBeforeBox
        {
            get { return textBeforeBox; }
            set { textBeforeBox = value; }
        }
        string textAfterBox;

        public string TextAfterBox
        {
            get { return textAfterBox; }
            set { textAfterBox = value; }
        }
        string submitButtonText;

        public string SubmitButtonText
        {
            get { return submitButtonText; }
            set { submitButtonText = value; }
        }

        public PageIndexBoxForm(ShowPageIndexBox showBox,int threshold,PageIndexBoxType boxType,string txtBefore,string txtAfter,string btnText)
        {
            InitializeComponent();
            showIndexBox = showBox;
            this.threshold = threshold;
            this.boxType = boxType;
            textBeforeBox = txtBefore;
            textAfterBox = txtAfter;
            submitButtonText = btnText;
        }

        private void PageIndexBoxForm_Load(object sender, EventArgs e)
        {
            num_threshold.Value = threshold;
            cmb_boxtype.SelectedIndex = (boxType == PageIndexBoxType.DropDownList) ? 1 : 0;
            switch (showIndexBox)
            {
                case ShowPageIndexBox.Always:
                    rb_always.Checked = true;
                    num_threshold.Enabled = false;
                    break;
                case ShowPageIndexBox.Never:
                    rb_never.Checked = true;
                    tb_btntxt.Enabled=tb_textaft.Enabled=tb_textbf.Enabled=num_threshold.Enabled = cmb_boxtype.Enabled = false;
                    break;
                default:
                    rb_auto.Checked = true;
                    break;
            }

        }

        private void RblCheckedChanged(object sender, EventArgs e)
        {
            if (rb_never.Checked)
            {
                tb_btntxt.Enabled = tb_textaft.Enabled = tb_textbf.Enabled = num_threshold.Enabled = cmb_boxtype.Enabled = false;
            }
            else if (rb_always.Checked)
            {
                num_threshold.Enabled = false;
                cmb_boxtype.Enabled = tb_textaft.Enabled = tb_textbf.Enabled = true;
                tb_btntxt.Enabled = cmb_boxtype.SelectedIndex == 0;                    
            }
            else
            {
                tb_textaft.Enabled = tb_textbf.Enabled = num_threshold.Enabled = cmb_boxtype.Enabled = true;
                tb_btntxt.Enabled = cmb_boxtype.SelectedIndex == 0;                   
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (rb_never.Checked)
                showIndexBox = ShowPageIndexBox.Never;
            else if (rb_always.Checked)
            {
                showIndexBox = ShowPageIndexBox.Always;
                boxType = (PageIndexBoxType)cmb_boxtype.SelectedIndex;
                textAfterBox = tb_textaft.Text;
                textBeforeBox = tb_textbf.Text;
                submitButtonText = tb_btntxt.Text;
            }
            else
            {
                showIndexBox = ShowPageIndexBox.Auto;
                threshold = (int)num_threshold.Value;
                boxType = (PageIndexBoxType)cmb_boxtype.SelectedIndex;
                textAfterBox = tb_textaft.Text;
                textBeforeBox = tb_textbf.Text;
                submitButtonText = tb_btntxt.Text;
            }
        }

        private void cmb_boxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_btntxt.Enabled=cmb_boxtype.SelectedIndex == 0;
        }
    }
}
