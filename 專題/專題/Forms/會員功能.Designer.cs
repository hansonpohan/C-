
namespace 專題.Forms
{
    partial class 會員功能
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
            this.btn登出 = new System.Windows.Forms.Button();
            this.btn修改會員資料 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn登出
            // 
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(685, 480);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(129, 53);
            this.btn登出.TabIndex = 0;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = true;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // btn修改會員資料
            // 
            this.btn修改會員資料.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改會員資料.Location = new System.Drawing.Point(117, 463);
            this.btn修改會員資料.Name = "btn修改會員資料";
            this.btn修改會員資料.Size = new System.Drawing.Size(155, 53);
            this.btn修改會員資料.TabIndex = 1;
            this.btn修改會員資料.Text = "修改會員資料";
            this.btn修改會員資料.UseVisualStyleBackColor = true;
            this.btn修改會員資料.Click += new System.EventHandler(this.btn修改會員資料_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt密碼);
            this.groupBox2.Controls.Add(this.dtp生日);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn修改會員資料);
            this.groupBox2.Controls.Add(this.txt帳號);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt地址);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 529);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "個人基本資料修改";
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(90, 134);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(263, 33);
            this.txt密碼.TabIndex = 3;
            // 
            // dtp生日
            // 
            this.dtp生日.Location = new System.Drawing.Point(90, 410);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(263, 33);
            this.dtp生日.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "生日:";
            // 
            // txt帳號
            // 
            this.txt帳號.Location = new System.Drawing.Point(90, 81);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(263, 33);
            this.txt帳號.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "帳號:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 359);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 33);
            this.txtEmail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // txt地址
            // 
            this.txt地址.Location = new System.Drawing.Point(90, 303);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(263, 33);
            this.txt地址.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "地址:";
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(90, 247);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(263, 33);
            this.txt電話.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "電話:";
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(90, 191);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(263, 33);
            this.txt姓名.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "姓名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Khaki;
            this.lblID.Location = new System.Drawing.Point(92, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(190, 24);
            this.lblID.TabIndex = 11;
            // 
            // 會員功能
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn登出);
            this.Name = "會員功能";
            this.Text = "會員功能";
            this.Load += new System.EventHandler(this.會員功能_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.Button btn修改會員資料;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
    }
}