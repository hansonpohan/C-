
namespace WindowsFormsApp1
{
    partial class FormLogin
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
            this.lbl使用者名稱 = new System.Windows.Forms.Label();
            this.lbl密碼 = new System.Windows.Forms.Label();
            this.txt使用者名稱 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn清除 = new System.Windows.Forms.Button();
            this.lbl回應訊息 = new System.Windows.Forms.Label();
            this.btn帳號申請 = new System.Windows.Forms.Button();
            this.btn忘記密碼 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.AutoSize = true;
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.Location = new System.Drawing.Point(94, 32);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(117, 26);
            this.lbl使用者名稱.TabIndex = 0;
            this.lbl使用者名稱.Text = "使用者名稱";
            // 
            // lbl密碼
            // 
            this.lbl密碼.AutoSize = true;
            this.lbl密碼.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl密碼.Location = new System.Drawing.Point(124, 135);
            this.lbl密碼.Name = "lbl密碼";
            this.lbl密碼.Size = new System.Drawing.Size(54, 26);
            this.lbl密碼.TabIndex = 1;
            this.lbl密碼.Text = "密碼";
            // 
            // txt使用者名稱
            // 
            this.txt使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt使用者名稱.Location = new System.Drawing.Point(82, 81);
            this.txt使用者名稱.Name = "txt使用者名稱";
            this.txt使用者名稱.Size = new System.Drawing.Size(147, 33);
            this.txt使用者名稱.TabIndex = 2;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(82, 181);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(147, 33);
            this.txt密碼.TabIndex = 3;
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(43, 312);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(102, 36);
            this.btn登入.TabIndex = 4;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn清除
            // 
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(173, 312);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(102, 36);
            this.btn清除.TabIndex = 5;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.BackColor = System.Drawing.Color.Thistle;
            this.lbl回應訊息.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回應訊息.Location = new System.Drawing.Point(55, 246);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(208, 47);
            this.lbl回應訊息.TabIndex = 6;
            this.lbl回應訊息.Text = "回應訊息";
            this.lbl回應訊息.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn帳號申請
            // 
            this.btn帳號申請.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn帳號申請.Location = new System.Drawing.Point(43, 378);
            this.btn帳號申請.Name = "btn帳號申請";
            this.btn帳號申請.Size = new System.Drawing.Size(102, 36);
            this.btn帳號申請.TabIndex = 7;
            this.btn帳號申請.Text = "帳號申請";
            this.btn帳號申請.UseVisualStyleBackColor = true;
            this.btn帳號申請.Click += new System.EventHandler(this.btn帳號申請_Click);
            // 
            // btn忘記密碼
            // 
            this.btn忘記密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn忘記密碼.Location = new System.Drawing.Point(173, 378);
            this.btn忘記密碼.Name = "btn忘記密碼";
            this.btn忘記密碼.Size = new System.Drawing.Size(102, 36);
            this.btn忘記密碼.TabIndex = 8;
            this.btn忘記密碼.Text = "忘記密碼";
            this.btn忘記密碼.UseVisualStyleBackColor = true;
            this.btn忘記密碼.Click += new System.EventHandler(this.btn忘記密碼_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(319, 439);
            this.Controls.Add(this.btn忘記密碼);
            this.Controls.Add(this.btn帳號申請);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt使用者名稱);
            this.Controls.Add(this.lbl密碼);
            this.Controls.Add(this.lbl使用者名稱);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormLogin";
            this.Text = "使用者登入";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl使用者名稱;
        private System.Windows.Forms.Label lbl密碼;
        private System.Windows.Forms.TextBox txt使用者名稱;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Label lbl回應訊息;
        private System.Windows.Forms.Button btn帳號申請;
        private System.Windows.Forms.Button btn忘記密碼;
    }
}