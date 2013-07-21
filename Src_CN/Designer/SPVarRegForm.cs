using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wuqi.Webdiyer
{
    public partial class SPVarRegForm : Form
    {
        string sqlVariables;

        public string SqlVariables
        {
            get { return sqlVariables; }
            set { sqlVariables = value; }
        }

        public SPVarRegForm(string sqlvars)
        {
            InitializeComponent();
            sqlVariables = sqlvars;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_vname.Text.Trim().Length == 0)
                MessageBox.Show("变量名称不能为空");
            else
            {
                string vname=tb_vname.Text.Trim().Trim('@');
                string dtype=cmb_dtype.SelectedItem.ToString();
                string size = tb_size.Text.Trim();
                if (size.Length > 0)
                    size = "(" + size + ")";
                listBox1.Items.Add("@" + vname + "  " + dtype + size);
            }
        }

        private void SPVarRegForm_Load(object sender, EventArgs e)
        {
            cmb_dtype.DataSource = Enum.GetNames(typeof(SqlDbType));
            cmb_dtype.SelectedItem = "Int";
            if (sqlVariables.Length > 0)
            {
                string[] svs = sqlVariables.Split(',');
                foreach (string s in svs)
                {
                    listBox1.Items.Add(s);
                }
            }
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in listBox1.Items)
            {
                sb.Append(s).Append(",");
            }
            sqlVariables=sb.ToString().Trim(',');
        }

        private void cmb_dtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sv = cmb_dtype.SelectedItem.ToString().ToLower();
            if (sv == "int" || sv == "bit" || sv == "tinyint" || sv == "smallint" || sv == "bitint" || sv == "datetime" || sv == "smalldatetime")
            {
                tb_size.Text = "";
                tb_size.Enabled = false;
            }
            else
                tb_size.Enabled = true;
        }
    }
}
