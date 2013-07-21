namespace Wuqi.Webdiyer
{
    partial class PageIndexBoxForm
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
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.rb_never = new System.Windows.Forms.RadioButton();
            this.rb_always = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.num_threshold = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_boxtype = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_textbf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_textaft = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_btntxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "页索引文本或下拉框显示方式：";
            // 
            // rb_auto
            // 
            this.rb_auto.AutoSize = true;
            this.rb_auto.Location = new System.Drawing.Point(23, 49);
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.Size = new System.Drawing.Size(47, 16);
            this.rb_auto.TabIndex = 1;
            this.rb_auto.TabStop = true;
            this.rb_auto.Text = "自动";
            this.rb_auto.UseVisualStyleBackColor = true;
            this.rb_auto.CheckedChanged += new System.EventHandler(this.RblCheckedChanged);
            // 
            // rb_never
            // 
            this.rb_never.AutoSize = true;
            this.rb_never.Location = new System.Drawing.Point(78, 49);
            this.rb_never.Name = "rb_never";
            this.rb_never.Size = new System.Drawing.Size(71, 16);
            this.rb_never.TabIndex = 2;
            this.rb_never.TabStop = true;
            this.rb_never.Text = "从不显示";
            this.rb_never.UseVisualStyleBackColor = true;
            this.rb_never.CheckedChanged += new System.EventHandler(this.RblCheckedChanged);
            // 
            // rb_always
            // 
            this.rb_always.AutoSize = true;
            this.rb_always.Location = new System.Drawing.Point(157, 49);
            this.rb_always.Name = "rb_always";
            this.rb_always.Size = new System.Drawing.Size(71, 16);
            this.rb_always.TabIndex = 3;
            this.rb_always.TabStop = true;
            this.rb_always.Text = "总是显示";
            this.rb_always.UseVisualStyleBackColor = true;
            this.rb_always.CheckedChanged += new System.EventHandler(this.RblCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "总页数超过";
            // 
            // num_threshold
            // 
            this.num_threshold.Location = new System.Drawing.Point(90, 79);
            this.num_threshold.Name = "num_threshold";
            this.num_threshold.Size = new System.Drawing.Size(42, 21);
            this.num_threshold.TabIndex = 5;
            this.num_threshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "时，自动显示页索引框";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "页索引框显示类型：";
            // 
            // cmb_boxtype
            // 
            this.cmb_boxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_boxtype.FormattingEnabled = true;
            this.cmb_boxtype.Items.AddRange(new object[] {
            "文本输入框",
            "下拉列表框"});
            this.cmb_boxtype.Location = new System.Drawing.Point(135, 110);
            this.cmb_boxtype.Name = "cmb_boxtype";
            this.cmb_boxtype.Size = new System.Drawing.Size(126, 20);
            this.cmb_boxtype.TabIndex = 8;
            this.cmb_boxtype.SelectedIndexChanged += new System.EventHandler(this.cmb_boxtype_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(208, 228);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 21);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消(&C)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(118, 228);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 21);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "确定(&O)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "页索引框前的文本：";
            // 
            // tb_textbf
            // 
            this.tb_textbf.Location = new System.Drawing.Point(135, 138);
            this.tb_textbf.Name = "tb_textbf";
            this.tb_textbf.Size = new System.Drawing.Size(127, 21);
            this.tb_textbf.TabIndex = 12;
            this.tb_textbf.Text = "转到";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "页索引框后的文本：";
            // 
            // tb_textaft
            // 
            this.tb_textaft.Location = new System.Drawing.Point(135, 167);
            this.tb_textaft.Name = "tb_textaft";
            this.tb_textaft.Size = new System.Drawing.Size(127, 21);
            this.tb_textaft.TabIndex = 14;
            this.tb_textaft.Text = "页";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "提交按钮上的文本：";
            // 
            // tb_btntxt
            // 
            this.tb_btntxt.Location = new System.Drawing.Point(135, 194);
            this.tb_btntxt.Name = "tb_btntxt";
            this.tb_btntxt.Size = new System.Drawing.Size(126, 21);
            this.tb_btntxt.TabIndex = 16;
            this.tb_btntxt.Text = "Go";
            // 
            // PageIndexBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 269);
            this.ControlBox = false;
            this.Controls.Add(this.tb_btntxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_textaft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_textbf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_boxtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_threshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_always);
            this.Controls.Add(this.rb_never);
            this.Controls.Add(this.rb_auto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PageIndexBoxForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置页索引文本或下拉框";
            this.Load += new System.EventHandler(this.PageIndexBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_auto;
        private System.Windows.Forms.RadioButton rb_never;
        private System.Windows.Forms.RadioButton rb_always;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_threshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_boxtype;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_textbf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_textaft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_btntxt;
    }
}