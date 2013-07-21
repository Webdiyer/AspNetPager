using System;
using System.Text;
using System.Windows.Forms;

namespace Wuqi.Webdiyer
{
    public partial class StoredProcForm : Form
    {
        public StoredProcForm()
        {
            InitializeComponent();
        }

        private void StoredProcForm_Load(object sender, EventArgs e)
        {
            cmb_sqlver.SelectedIndex = 1;
        }

        private void btn_gensp_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string spname = tb_spname.Text.Trim();
                string tblname = tb_tblname.Text.Trim();
                string pkfield = tb_idname.Text.Trim();
                string orderfld = tb_ofldname.Text.Trim();
                string fldlist = tb_fields.Text.Trim(new char[] { ',', ' ' });
                if (fldlist.Length > 1)
                {
                    StringBuilder fldsb = new StringBuilder();
                    string[] flds = fldlist.Split(',');
                    foreach (string s in flds)
                    {
                        fldsb.Append("O.").Append(s).Append(",");
                    }
                    fldlist = fldsb.ToString().Trim(new char[] { ',', ' ' });
                }
                string spvar = tb_vars.Text.Trim();
                if (spvar.Length > 0)
                    spvar = spvar.Replace(",", ",\n");
                string sqlwhere = tb_where.Text.Trim().ToLower();
                if (sqlwhere.Length > 0)
                {
                    if (!sqlwhere.StartsWith("where"))
                        sqlwhere = " where " + sqlwhere;
                    else
                        sqlwhere = " " + sqlwhere;
                }
                string orderdir = rb_asc.Checked ? "asc" : "desc";
                bool docount = !ckb_rconly.Checked;
                bool isSQL2005 = (cmb_sqlver.SelectedIndex == 1);

                string docountDec = string.Empty;
                string docountClause = string.Empty;

                if (docount)
                {
                    docountDec = ",\n@docount bit";
                    docountClause = "\nif(@docount=1)\nselect count(*) from " + tblname + sqlwhere + "\nelse";
                }
                StringBuilder sb;

                if (isSQL2005)
                    sb = new StringBuilder("create procedure %spname% %newline%(%sqlvariables%@startIndex int,%newline%@endIndex int%docountdec%)%newline%as%newline%%docountclause%%newline%begin%newline% with temptbl as (%newline%SELECT ROW_NUMBER() OVER (ORDER BY %orderfld% %orderdir%)AS Row, %fieldlist% from %tblname% %where%)%newline% SELECT * FROM temptbl where Row between @startIndex and @endIndex%newline%end");
                else
                    sb = new StringBuilder("create procedure %spname% %newline%(%sqlvariables%@startIndex int,%newline%@endIndex int%docountdec%)%newline%as%newline%set nocount on%docountclause%%newline%begin%newline%declare @indextable table(id int identity(1,1),nid int)%newline%set rowcount @endIndex%newline%insert into @indextable(nid) select %pkfield% from %tblname% %where% order by %orderfld% %orderdir%%newline%select %fieldlist% from %tblname% O,@indextable t where O.%pkfield%=t.nid%newline%and t.id between @startIndex and @endIndex order by t.id%newline%end%newline%set nocount off%newline%");
                sb.Replace("%spname%", spname).Replace("%sqlvariables%", spvar).Replace("%orderfld%", orderfld).Replace("%orderdir%", orderdir);
                sb.Replace("%tblname%", tblname).Replace("%docountdec%", docountDec).Replace("%docountclause%", docountClause);
                sb.Replace("%where%", sqlwhere).Replace("%fieldlist%", fldlist).Replace("%pkfield%", pkfield).Replace("%newline%", "\n");
                Clipboard.SetText(sb.ToString());
                MessageBox.Show("已生成存储过程并复制到剪贴板");
            }
        }

        private void tb_spname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_spname.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tb_spname, "存储过程名称不能为空");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tb_spname, "");
        }

        private void tb_tblname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_tblname.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tb_tblname, "数据库表名不能为空");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tb_tblname, "");
        }

        private void tb_idname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_idname.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tb_idname, "标识字段名不能为空");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tb_idname, "");
        }

        private void tb_ofldname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_ofldname.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tb_ofldname, "排序字段名不能为空");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tb_ofldname, "");
        }

        private void btn_regvar_Click(object sender, EventArgs e)
        {
            SPVarRegForm f = new SPVarRegForm(tb_vars.Text);
            if (f.ShowDialog(this) == DialogResult.OK)
                tb_vars.Text = f.SqlVariables;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            SPHelpForm frm = new SPHelpForm();
            frm.ShowDialog(this);
        }

    }
}
