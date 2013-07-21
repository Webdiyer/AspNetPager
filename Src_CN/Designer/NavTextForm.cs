using System;
using System.Windows.Forms;

namespace Wuqi.Webdiyer
{
    public partial class NavTextForm : Form
    {
        string firstPageText;

        public string FirstPageText
        {
            get { return firstPageText; }
            set { firstPageText = value; }
        }
        string lastPageText;

        public string LastPageText
        {
            get { return lastPageText; }
            set { lastPageText = value; }
        }
        string prevPageText;

        public string PrevPageText
        {
            get { return prevPageText; }
            set { prevPageText = value; }
        }
        string nextPageText;

        public string NextPageText
        {
            get { return nextPageText; }
            set { nextPageText = value; }
        }



        public NavTextForm(string firstTest, string lastText, string prevText, string nextText)
        {
            InitializeComponent();
            firstPageText = firstTest;
            lastPageText = lastText;
            prevPageText = prevText;
            nextPageText = nextText;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            switch (index)
            {
                case 1:
                    tb_first.Text = "首页";
                    tb_last.Text = "尾页";
                    tb_prev.Text = "前页";
                    tb_next.Text = "后页";
                    break;
                case 2:
                    tb_first.Text = "首页";
                    tb_last.Text = "尾页";
                    tb_prev.Text = "上一页";
                    tb_next.Text = "下一页";
                    break;
                case 3:
                    tb_first.Text = "First";
                    tb_last.Text = "Last";
                    tb_prev.Text = "Prev";
                    tb_next.Text = "Next";
                    break;
                default:
                    tb_first.Text = "&lt;&lt;";
                    tb_last.Text = "&gt;&gt;";
                    tb_prev.Text = "&lt;";
                    tb_next.Text = "&gt;";
                    break;
            }
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            firstPageText = tb_first.Text;
            lastPageText = tb_last.Text;
            prevPageText = tb_prev.Text;
            nextPageText = tb_next.Text;
        }

        private void NavTextForm_Load(object sender, EventArgs e)
        {
            tb_first.Text = firstPageText;
            tb_last.Text = lastPageText;
            tb_prev.Text = prevPageText;
            tb_next.Text = nextPageText;
        }
    }
}
