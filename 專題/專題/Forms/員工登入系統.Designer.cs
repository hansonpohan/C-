
namespace 專題.Forms
{
    partial class 員工登入系統
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn員工清除 = new System.Windows.Forms.Button();
            this.btn員工登入 = new System.Windows.Forms.Button();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn員工清除);
            this.groupBox1.Controls.Add(this.btn員工登入);
            this.groupBox1.Controls.Add(this.txt密碼);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt帳號);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(222, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 470);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "帳號登入";
            // 
            // btn員工清除
            // 
            this.btn員工清除.Location = new System.Drawing.Point(216, 339);
            this.btn員工清除.Name = "btn員工清除";
            this.btn員工清除.Size = new System.Drawing.Size(106, 43);
            this.btn員工清除.TabIndex = 9;
            this.btn員工清除.Text = "清除";
            this.btn員工清除.UseVisualStyleBackColor = true;
            this.btn員工清除.Click += new System.EventHandler(this.btn員工清除_Click);
            // 
            // btn員工登入
            // 
            this.btn員工登入.Location = new System.Drawing.Point(51, 339);
            this.btn員工登入.Name = "btn員工登入";
            this.btn員工登入.Size = new System.Drawing.Size(106, 43);
            this.btn員工登入.TabIndex = 8;
            this.btn員工登入.Text = "員工登入";
            this.btn員工登入.UseVisualStyleBackColor = true;
            this.btn員工登入.Click += new System.EventHandler(this.btn員工登入_Click);
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(111, 177);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(211, 35);
            this.txt密碼.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // txt帳號
            // 
            this.txt帳號.Location = new System.Drawing.Point(111, 87);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(211, 35);
            this.txt帳號.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // 員工登入系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(799, 583);
            this.Controls.Add(this.groupBox1);
            this.Name = "員工登入系統";
            this.Text = "員工登入系統";
            this.Load += new System.EventHandler(this.員工登入系統_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn員工清除;
        private System.Windows.Forms.Button btn員工登入;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label1;
    }
}