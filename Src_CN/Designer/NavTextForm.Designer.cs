namespace Wuqi.Webdiyer
{
    partial class NavTextForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_first = new System.Windows.Forms.TextBox();
            this.tb_prev = new System.Windows.Forms.TextBox();
            this.tb_last = new System.Windows.Forms.TextBox();
            this.tb_next = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "首页按钮文本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "尾页按钮文本：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "上页按钮文本：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "下页按钮文本：";
            // 
            // tb_first
            // 
            this.tb_first.Location = new System.Drawing.Point(110, 170);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(80, 21);
            this.tb_first.TabIndex = 4;
            // 
            // tb_prev
            // 
            this.tb_prev.Location = new System.Drawing.Point(110, 198);
            this.tb_prev.Name = "tb_prev";
            this.tb_prev.Size = new System.Drawing.Size(80, 21);
            this.tb_prev.TabIndex = 5;
            // 
            // tb_last
            // 
            this.tb_last.Location = new System.Drawing.Point(284, 173);
            this.tb_last.Name = "tb_last";
            this.tb_last.Size = new System.Drawing.Size(82, 21);
            this.tb_last.TabIndex = 6;
            // 
            // tb_next
            // 
            this.tb_next.Location = new System.Drawing.Point(284, 201);
            this.tb_next.Name = "tb_next";
            this.tb_next.Size = new System.Drawing.Size(82, 21);
            this.tb_next.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "请从下面的列表中选择预定义的导航按钮文本样式，或根据需要手工输入或修改文本框中相应的属性值：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "默认（<<  < ... >  >>）",
            "首页  前页 ... 后页  尾页",
            "首页  上一页 ... 下一页  尾页",
            "First  Prev ...  Next  Last"});
            this.listBox1.Location = new System.Drawing.Point(25, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 112);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(201, 232);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 21);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "确定(&O)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(291, 232);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 21);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "取消(&C)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // NavTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 277);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_next);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.tb_prev);
            this.Controls.Add(this.tb_first);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NavTextForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置导航按钮文本";
            this.Load += new System.EventHandler(this.NavTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_first;
        private System.Windows.Forms.TextBox tb_prev;
        private System.Windows.Forms.TextBox tb_last;
        private System.Windows.Forms.TextBox tb_next;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}