
namespace WindowsFormsApp1
{
    partial class Formlostpass
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt設定使用者名稱 = new System.Windows.Forms.TextBox();
            this.lbl密碼顯示 = new System.Windows.Forms.Label();
            this.btn清除 = new System.Windows.Forms.Button();
            this.btn確認 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.AutoSize = true;
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.Location = new System.Drawing.Point(31, 72);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(122, 26);
            this.lbl使用者名稱.TabIndex = 2;
            this.lbl使用者名稱.Text = "使用者名稱:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(80, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(159, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 33);
            this.txtEmail.TabIndex = 12;
            // 
            // txt設定使用者名稱
            // 
            this.txt設定使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt設定使用者名稱.Location = new System.Drawing.Point(159, 71);
            this.txt設定使用者名稱.Name = "txt設定使用者名稱";
            this.txt設定使用者名稱.Size = new System.Drawing.Size(147, 33);
            this.txt設定使用者名稱.TabIndex = 11;
            // 
            // lbl密碼顯示
            // 
            this.lbl密碼顯示.BackColor = System.Drawing.Color.Thistle;
            this.lbl密碼顯示.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl密碼顯示.Location = new System.Drawing.Point(159, 184);
            this.lbl密碼顯示.Name = "lbl密碼顯示";
            this.lbl密碼顯示.Size = new System.Drawing.Size(147, 40);
            this.lbl密碼顯示.TabIndex = 13;
            this.lbl密碼顯示.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn清除
            // 
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(216, 252);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(90, 36);
            this.btn清除.TabIndex = 15;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // btn確認
            // 
            this.btn確認.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認.Location = new System.Drawing.Point(49, 252);
            this.btn確認.Name = "btn確認";
            this.btn確認.Size = new System.Drawing.Size(90, 36);
            this.btn確認.TabIndex = 14;
            this.btn確認.Text = "確認";
            this.btn確認.UseVisualStyleBackColor = true;
            this.btn確認.Click += new System.EventHandler(this.btn確認_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(94, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "密碼:";
            // 
            // Formlostpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(357, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.btn確認);
            this.Controls.Add(this.lbl密碼顯示);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txt設定使用者名稱);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl使用者名稱);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Formlostpass";
            this.Text = "忘記密碼";
            this.Load += new System.EventHandler(this.Formlostpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl使用者名稱;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt設定使用者名稱;
        private System.Windows.Forms.Label lbl密碼顯示;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Button btn確認;
        private System.Windows.Forms.Label label1;
    }
}