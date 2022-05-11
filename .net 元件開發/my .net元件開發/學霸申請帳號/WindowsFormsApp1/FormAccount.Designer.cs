
namespace WindowsFormsApp1
{
    partial class FormAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt設定使用者名稱 = new System.Windows.Forms.TextBox();
            this.txt設定密碼 = new System.Windows.Forms.TextBox();
            this.txt確認密碼 = new System.Windows.Forms.TextBox();
            this.btn確認 = new System.Windows.Forms.Button();
            this.btn清除 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.AutoSize = true;
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.Location = new System.Drawing.Point(25, 91);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(164, 26);
            this.lbl使用者名稱.TabIndex = 1;
            this.lbl使用者名稱.Text = "設定使用者名稱:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(88, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "設定密碼:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(88, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "確認密碼:";
            // 
            // txt設定使用者名稱
            // 
            this.txt設定使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt設定使用者名稱.Location = new System.Drawing.Point(195, 90);
            this.txt設定使用者名稱.Name = "txt設定使用者名稱";
            this.txt設定使用者名稱.Size = new System.Drawing.Size(147, 33);
            this.txt設定使用者名稱.TabIndex = 4;
            // 
            // txt設定密碼
            // 
            this.txt設定密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt設定密碼.Location = new System.Drawing.Point(195, 143);
            this.txt設定密碼.Name = "txt設定密碼";
            this.txt設定密碼.PasswordChar = '*';
            this.txt設定密碼.Size = new System.Drawing.Size(147, 33);
            this.txt設定密碼.TabIndex = 5;
            // 
            // txt確認密碼
            // 
            this.txt確認密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt確認密碼.Location = new System.Drawing.Point(195, 199);
            this.txt確認密碼.Name = "txt確認密碼";
            this.txt確認密碼.PasswordChar = '*';
            this.txt確認密碼.Size = new System.Drawing.Size(147, 33);
            this.txt確認密碼.TabIndex = 6;
            // 
            // btn確認
            // 
            this.btn確認.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認.Location = new System.Drawing.Point(75, 328);
            this.btn確認.Name = "btn確認";
            this.btn確認.Size = new System.Drawing.Size(90, 36);
            this.btn確認.TabIndex = 7;
            this.btn確認.Text = "確認";
            this.btn確認.UseVisualStyleBackColor = true;
            this.btn確認.Click += new System.EventHandler(this.btn確認_Click);
            // 
            // btn清除
            // 
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(233, 328);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(90, 36);
            this.btn清除.TabIndex = 8;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(116, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(195, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 33);
            this.txtEmail.TabIndex = 10;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(410, 422);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.btn確認);
            this.Controls.Add(this.txt確認密碼);
            this.Controls.Add(this.txt設定密碼);
            this.Controls.Add(this.txt設定使用者名稱);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl使用者名稱);
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl使用者名稱;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt設定使用者名稱;
        private System.Windows.Forms.TextBox txt設定密碼;
        private System.Windows.Forms.TextBox txt確認密碼;
        private System.Windows.Forms.Button btn確認;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
    }
}