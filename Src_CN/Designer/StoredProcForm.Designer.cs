namespace Wuqi.Webdiyer
{
    partial class StoredProcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_spname = new System.Windows.Forms.TextBox();
            this.tb_tblname = new System.Windows.Forms.TextBox();
            this.tb_idname = new System.Windows.Forms.TextBox();
            this.tb_ofldname = new System.Windows.Forms.TextBox();
            this.rb_asc = new System.Windows.Forms.RadioButton();
            this.rb_desc = new System.Windows.Forms.RadioButton();
            this.tb_fields = new System.Windows.Forms.TextBox();
            this.tb_vars = new System.Windows.Forms.TextBox();
            this.tb_where = new System.Windows.Forms.TextBox();
            this.ckb_rconly = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_sqlver = new System.Windows.Forms.ComboBox();
            this.btn_gensp = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_regvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "存储过程名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库表名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "标识字段名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "排序字段名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(533, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "字段列表：select语句中要选择的字段列表，字段名间用英文标点“,”分隔，用“*”表示所有字段";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "注册变量（可选）：存储过程中需要额外添加的变量，可以用来在where子句中做为条件值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Where子句（可选）：SQL语句中的where子句，用来过滤指定条件的数据";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(308, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "排序方式：";
            // 
            // tb_spname
            // 
            this.tb_spname.Location = new System.Drawing.Point(109, 30);
            this.tb_spname.Name = "tb_spname";
            this.tb_spname.Size = new System.Drawing.Size(257, 21);
            this.tb_spname.TabIndex = 9;
            this.tb_spname.Validating += new System.ComponentModel.CancelEventHandler(this.tb_spname_Validating);
            // 
            // tb_tblname
            // 
            this.tb_tblname.Location = new System.Drawing.Point(109, 52);
            this.tb_tblname.Name = "tb_tblname";
            this.tb_tblname.Size = new System.Drawing.Size(257, 21);
            this.tb_tblname.TabIndex = 10;
            this.tb_tblname.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tblname_Validating);
            // 
            // tb_idname
            // 
            this.tb_idname.Location = new System.Drawing.Point(109, 74);
            this.tb_idname.Name = "tb_idname";
            this.tb_idname.Size = new System.Drawing.Size(191, 21);
            this.tb_idname.TabIndex = 11;
            this.tb_idname.Validating += new System.ComponentModel.CancelEventHandler(this.tb_idname_Validating);
            // 
            // tb_ofldname
            // 
            this.tb_ofldname.Location = new System.Drawing.Point(109, 96);
            this.tb_ofldname.Name = "tb_ofldname";
            this.tb_ofldname.Size = new System.Drawing.Size(194, 21);
            this.tb_ofldname.TabIndex = 12;
            this.tb_ofldname.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ofldname_Validating);
            // 
            // rb_asc
            // 
            this.rb_asc.AutoSize = true;
            this.rb_asc.Location = new System.Drawing.Point(372, 98);
            this.rb_asc.Name = "rb_asc";
            this.rb_asc.Size = new System.Drawing.Size(47, 16);
            this.rb_asc.TabIndex = 13;
            this.rb_asc.Text = "升序";
            this.rb_asc.UseVisualStyleBackColor = true;
            // 
            // rb_desc
            // 
            this.rb_desc.AutoSize = true;
            this.rb_desc.Checked = true;
            this.rb_desc.Location = new System.Drawing.Point(419, 98);
            this.rb_desc.Name = "rb_desc";
            this.rb_desc.Size = new System.Drawing.Size(47, 16);
            this.rb_desc.TabIndex = 14;
            this.rb_desc.TabStop = true;
            this.rb_desc.Text = "降序";
            this.rb_desc.UseVisualStyleBackColor = true;
            // 
            // tb_fields
            // 
            this.tb_fields.Location = new System.Drawing.Point(19, 143);
            this.tb_fields.Name = "tb_fields";
            this.tb_fields.Size = new System.Drawing.Size(477, 21);
            this.tb_fields.TabIndex = 15;
            this.tb_fields.Text = "*";
            // 
            // tb_vars
            // 
            this.tb_vars.Location = new System.Drawing.Point(19, 194);
            this.tb_vars.Name = "tb_vars";
            this.tb_vars.ReadOnly = true;
            this.tb_vars.Size = new System.Drawing.Size(385, 21);
            this.tb_vars.TabIndex = 16;
            // 
            // tb_where
            // 
            this.tb_where.Location = new System.Drawing.Point(19, 249);
            this.tb_where.Multiline = true;
            this.tb_where.Name = "tb_where";
            this.tb_where.Size = new System.Drawing.Size(477, 57);
            this.tb_where.TabIndex = 17;
            // 
            // ckb_rconly
            // 
            this.ckb_rconly.AutoSize = true;
            this.ckb_rconly.Location = new System.Drawing.Point(21, 311);
            this.ckb_rconly.Name = "ckb_rconly";
            this.ckb_rconly.Size = new System.Drawing.Size(222, 16);
            this.ckb_rconly.TabIndex = 18;
            this.ckb_rconly.Text = "不统计记录总数，仅获取分页的数据 ";
            this.ckb_rconly.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "SQL Server 数据库版本：";
            // 
            // cmb_sqlver
            // 
            this.cmb_sqlver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sqlver.FormattingEnabled = true;
            this.cmb_sqlver.Items.AddRange(new object[] {
            "SQL Server 2000",
            "SQL Server 2005"});
            this.cmb_sqlver.Location = new System.Drawing.Point(158, 332);
            this.cmb_sqlver.Name = "cmb_sqlver";
            this.cmb_sqlver.Size = new System.Drawing.Size(198, 20);
            this.cmb_sqlver.TabIndex = 20;
            // 
            // btn_gensp
            // 
            this.btn_gensp.Location = new System.Drawing.Point(18, 367);
            this.btn_gensp.Name = "btn_gensp";
            this.btn_gensp.Size = new System.Drawing.Size(219, 41);
            this.btn_gensp.TabIndex = 21;
            this.btn_gensp.Text = "生成存储过程并复制到剪贴板(&G)";
            this.btn_gensp.UseVisualStyleBackColor = true;
            this.btn_gensp.Click += new System.EventHandler(this.btn_gensp_Click);
            // 
            // btn_close
            // 
            this.btn_close.CausesValidation = false;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(452, 462);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 21);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "关闭(&C)";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_regvar
            // 
            this.btn_regvar.Location = new System.Drawing.Point(411, 191);
            this.btn_regvar.Name = "btn_regvar";
            this.btn_regvar.Size = new System.Drawing.Size(84, 21);
            this.btn_regvar.TabIndex = 23;
            this.btn_regvar.Text = "注册(&R)...";
            this.btn_regvar.UseVisualStyleBackColor = true;
            this.btn_regvar.Click += new System.EventHandler(this.btn_regvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_help);
            this.groupBox1.Controls.Add(this.tb_where);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_gensp);
            this.groupBox1.Controls.Add(this.btn_regvar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_desc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_asc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_sqlver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ckb_rconly);
            this.groupBox1.Controls.Add(this.tb_spname);
            this.groupBox1.Controls.Add(this.tb_tblname);
            this.groupBox1.Controls.Add(this.tb_vars);
            this.groupBox1.Controls.Add(this.tb_idname);
            this.groupBox1.Controls.Add(this.tb_fields);
            this.groupBox1.Controls.Add(this.tb_ofldname);
            this.groupBox1.Location = new System.Drawing.Point(19, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 422);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "创建SQL Server分页存储过程";
            // 
            // btn_help
            // 
            this.btn_help.CausesValidation = false;
            this.btn_help.Location = new System.Drawing.Point(276, 367);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(219, 41);
            this.btn_help.TabIndex = 24;
            this.btn_help.Text = "存储过程使用说明(&H)...";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StoredProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 510);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StoredProcForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分页存储过程生成工具";
            this.Load += new System.EventHandler(this.StoredProcForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_spname;
        private System.Windows.Forms.TextBox tb_tblname;
        private System.Windows.Forms.TextBox tb_idname;
        private System.Windows.Forms.TextBox tb_ofldname;
        private System.Windows.Forms.RadioButton rb_asc;
        private System.Windows.Forms.RadioButton rb_desc;
        private System.Windows.Forms.TextBox tb_fields;
        private System.Windows.Forms.TextBox tb_vars;
        private System.Windows.Forms.TextBox tb_where;
        private System.Windows.Forms.CheckBox ckb_rconly;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_sqlver;
        private System.Windows.Forms.Button btn_gensp;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_regvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_help;
    }
}