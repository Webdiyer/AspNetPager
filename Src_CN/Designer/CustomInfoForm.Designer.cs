namespace Wuqi.Webdiyer
{
    partial class CustomInfoForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_propvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_right = new System.Windows.Forms.RadioButton();
            this.rb_left = new System.Windows.Forms.RadioButton();
            this.rb_never = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "默认设置（Page N of M）",
            "总页数及当前页",
            "总页数、当前页及每页记录数",
            "当前页、总页数及每页记录数"});
            this.listBox1.Location = new System.Drawing.Point(25, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 64);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "属性值：";
            // 
            // tb_propvalue
            // 
            this.tb_propvalue.Location = new System.Drawing.Point(25, 196);
            this.tb_propvalue.Multiline = true;
            this.tb_propvalue.Name = "tb_propvalue";
            this.tb_propvalue.Size = new System.Drawing.Size(299, 57);
            this.tb_propvalue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "显示效果预览：";
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.ForeColor = System.Drawing.Color.Blue;
            this.lbl_preview.Location = new System.Drawing.Point(25, 278);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(0, 12);
            this.lbl_preview.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "请从下面预定义的内容模板中选择自定义信息，或者根据需要手工修改属性值文本框中的属性值：";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(280, 318);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 21);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "取消(&C)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(195, 318);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 21);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "确定(&O)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "自定义信息区显示在分页导航栏的：";
            // 
            // rb_right
            // 
            this.rb_right.AutoSize = true;
            this.rb_right.Location = new System.Drawing.Point(172, 39);
            this.rb_right.Name = "rb_right";
            this.rb_right.Size = new System.Drawing.Size(47, 16);
            this.rb_right.TabIndex = 9;
            this.rb_right.TabStop = true;
            this.rb_right.Text = "右边";
            this.rb_right.UseVisualStyleBackColor = true;
            this.rb_right.CheckedChanged += new System.EventHandler(this.CustomInfoChanged);
            // 
            // rb_left
            // 
            this.rb_left.AutoSize = true;
            this.rb_left.Location = new System.Drawing.Point(107, 39);
            this.rb_left.Name = "rb_left";
            this.rb_left.Size = new System.Drawing.Size(47, 16);
            this.rb_left.TabIndex = 10;
            this.rb_left.TabStop = true;
            this.rb_left.Text = "左边";
            this.rb_left.UseVisualStyleBackColor = true;
            this.rb_left.CheckedChanged += new System.EventHandler(this.CustomInfoChanged);
            // 
            // rb_never
            // 
            this.rb_never.AutoSize = true;
            this.rb_never.Location = new System.Drawing.Point(28, 39);
            this.rb_never.Name = "rb_never";
            this.rb_never.Size = new System.Drawing.Size(71, 16);
            this.rb_never.TabIndex = 11;
            this.rb_never.TabStop = true;
            this.rb_never.Text = "从不显示";
            this.rb_never.UseVisualStyleBackColor = true;
            this.rb_never.CheckedChanged += new System.EventHandler(this.CustomInfoChanged);
            // 
            // CustomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 358);
            this.ControlBox = false;
            this.Controls.Add(this.rb_never);
            this.Controls.Add(this.rb_left);
            this.Controls.Add(this.rb_right);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_preview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_propvalue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CustomInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置自定义信息区显示内容";
            this.Load += new System.EventHandler(this.CustomInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_propvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_right;
        private System.Windows.Forms.RadioButton rb_left;
        private System.Windows.Forms.RadioButton rb_never;
    }
}