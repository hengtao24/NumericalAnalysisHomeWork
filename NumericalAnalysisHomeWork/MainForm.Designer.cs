namespace NumericalAnalysisHomeWork
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InitialValueTextBox = new System.Windows.Forms.TextBox();
            this.ToleranceErrortextBox = new System.Windows.Forms.TextBox();
            this.StartIterationbutton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.FindMaxSigmabutton = new System.Windows.Forms.Button();
            this.ToleranceErrortextBox2 = new System.Windows.Forms.TextBox();
            this.StepLengthtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 346);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "P20/17";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(538, 314);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FindMaxSigmabutton);
            this.tabPage2.Controls.Add(this.ToleranceErrortextBox2);
            this.tabPage2.Controls.Add(this.StepLengthtextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.StartIterationbutton);
            this.tabPage2.Controls.Add(this.ToleranceErrortextBox);
            this.tabPage2.Controls.Add(this.InitialValueTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "P56/20";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "初值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "容许误差";
            // 
            // InitialValueTextBox
            // 
            this.InitialValueTextBox.Location = new System.Drawing.Point(44, 4);
            this.InitialValueTextBox.Name = "InitialValueTextBox";
            this.InitialValueTextBox.Size = new System.Drawing.Size(100, 21);
            this.InitialValueTextBox.TabIndex = 2;
            this.InitialValueTextBox.TextChanged += new System.EventHandler(this.InitialValueTextBox_TextChanged);
            // 
            // ToleranceErrortextBox
            // 
            this.ToleranceErrortextBox.Location = new System.Drawing.Point(216, 3);
            this.ToleranceErrortextBox.Name = "ToleranceErrortextBox";
            this.ToleranceErrortextBox.Size = new System.Drawing.Size(100, 21);
            this.ToleranceErrortextBox.TabIndex = 3;
            this.ToleranceErrortextBox.TextChanged += new System.EventHandler(this.ToleranceErrortextBox_TextChanged);
            // 
            // StartIterationbutton
            // 
            this.StartIterationbutton.Location = new System.Drawing.Point(355, 4);
            this.StartIterationbutton.Name = "StartIterationbutton";
            this.StartIterationbutton.Size = new System.Drawing.Size(75, 23);
            this.StartIterationbutton.TabIndex = 4;
            this.StartIterationbutton.Text = "开始迭代";
            this.StartIterationbutton.UseVisualStyleBackColor = true;
            this.StartIterationbutton.Click += new System.EventHandler(this.StartIterationbutton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 60);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(542, 262);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // FindMaxSigmabutton
            // 
            this.FindMaxSigmabutton.Location = new System.Drawing.Point(355, 31);
            this.FindMaxSigmabutton.Name = "FindMaxSigmabutton";
            this.FindMaxSigmabutton.Size = new System.Drawing.Size(75, 23);
            this.FindMaxSigmabutton.TabIndex = 10;
            this.FindMaxSigmabutton.Text = "寻找Sigma";
            this.FindMaxSigmabutton.UseVisualStyleBackColor = true;
            this.FindMaxSigmabutton.Click += new System.EventHandler(this.FindMaxSigmabutton_Click);
            // 
            // ToleranceErrortextBox2
            // 
            this.ToleranceErrortextBox2.Location = new System.Drawing.Point(216, 30);
            this.ToleranceErrortextBox2.Name = "ToleranceErrortextBox2";
            this.ToleranceErrortextBox2.Size = new System.Drawing.Size(100, 21);
            this.ToleranceErrortextBox2.TabIndex = 9;
            this.ToleranceErrortextBox2.TextChanged += new System.EventHandler(this.ToleranceErrortextBox2_TextChanged);
            // 
            // StepLengthtextBox
            // 
            this.StepLengthtextBox.Location = new System.Drawing.Point(44, 31);
            this.StepLengthtextBox.Name = "StepLengthtextBox";
            this.StepLengthtextBox.Size = new System.Drawing.Size(100, 21);
            this.StepLengthtextBox.TabIndex = 8;
            this.StepLengthtextBox.TextChanged += new System.EventHandler(this.StepLengthtextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "容许误差";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "步长";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "数值分析上机题";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartIterationbutton;
        private System.Windows.Forms.TextBox ToleranceErrortextBox;
        private System.Windows.Forms.TextBox InitialValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button FindMaxSigmabutton;
        private System.Windows.Forms.TextBox ToleranceErrortextBox2;
        private System.Windows.Forms.TextBox StepLengthtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

