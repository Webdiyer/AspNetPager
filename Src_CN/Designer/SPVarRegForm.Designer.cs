namespace Wuqi.Webdiyer
{
    partial class SPVarRegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_vname = new System.Windows.Forms.TextBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.cmb_dtype = new System.Windows.Forms.ComboBox();
            this.btn_rem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "变量名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "变量宽度：";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(212, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 21);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = ">>";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_vname
            // 
            this.tb_vname.Location = new System.Drawing.Point(86, 24);
            this.tb_vname.Name = "tb_vname";
            this.tb_vname.Size = new System.Drawing.Size(114, 21);
            this.tb_vname.TabIndex = 4;
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(86, 87);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(114, 21);
            this.tb_size.TabIndex = 5;
            // 
            // cmb_dtype
            // 
            this.cmb_dtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dtype.FormattingEnabled = true;
            this.cmb_dtype.Location = new System.Drawing.Point(86, 54);
            this.cmb_dtype.Name = "cmb_dtype";
            this.cmb_dtype.Size = new System.Drawing.Size(114, 20);
            this.cmb_dtype.TabIndex = 6;
            this.cmb_dtype.SelectedIndexChanged += new System.EventHandler(this.cmb_dtype_SelectedIndexChanged);
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(212, 78);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(36, 21);
            this.btn_rem.TabIndex = 7;
            this.btn_rem.Text = "<<";
            this.btn_rem.UseVisualStyleBackColor = true;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(258, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 88);
            this.listBox1.TabIndex = 8;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(137, 142);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 21);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "确定(&O)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(228, 142);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 21);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "取消(&C)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_vname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_rem);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.cmb_dtype);
            this.groupBox1.Controls.Add(this.tb_size);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册变量";
            // 
            // SPVarRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 181);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SPVarRegForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册存储过程变量";
            this.Load += new System.EventHandler(this.SPVarRegForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_vname;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.ComboBox cmb_dtype;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}