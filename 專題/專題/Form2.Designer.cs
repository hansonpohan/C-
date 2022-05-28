
namespace 專題
{
    partial class Form2
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
            this.存放form = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn登出 = new System.Windows.Forms.Button();
            this.btn返回主頁 = new System.Windows.Forms.Button();
            this.btn會員功能 = new System.Windows.Forms.Button();
            this.btn結帳單 = new System.Windows.Forms.Button();
            this.btn目錄 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.存放form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 存放form
            // 
            this.存放form.Controls.Add(this.pictureBox1);
            this.存放form.Location = new System.Drawing.Point(184, 97);
            this.存放form.Name = "存放form";
            this.存放form.Size = new System.Drawing.Size(868, 620);
            this.存放form.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::專題.Properties.Resources.手機陳列;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn登出);
            this.panel1.Controls.Add(this.btn返回主頁);
            this.panel1.Controls.Add(this.btn會員功能);
            this.panel1.Controls.Add(this.btn結帳單);
            this.panel1.Controls.Add(this.btn目錄);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 722);
            this.panel1.TabIndex = 3;
            // 
            // btn登出
            // 
            this.btn登出.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(0, 652);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(184, 70);
            this.btn登出.TabIndex = 6;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = true;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // btn返回主頁
            // 
            this.btn返回主頁.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回主頁.Location = new System.Drawing.Point(0, 587);
            this.btn返回主頁.Name = "btn返回主頁";
            this.btn返回主頁.Size = new System.Drawing.Size(184, 70);
            this.btn返回主頁.TabIndex = 3;
            this.btn返回主頁.Text = "返回主頁";
            this.btn返回主頁.UseVisualStyleBackColor = true;
            this.btn返回主頁.Click += new System.EventHandler(this.btn返回主頁_Click);
            // 
            // btn會員功能
            // 
            this.btn會員功能.BackColor = System.Drawing.Color.DarkGray;
            this.btn會員功能.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn會員功能.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn會員功能.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員功能.Location = new System.Drawing.Point(0, 256);
            this.btn會員功能.Name = "btn會員功能";
            this.btn會員功能.Size = new System.Drawing.Size(184, 78);
            this.btn會員功能.TabIndex = 5;
            this.btn會員功能.Text = "會員功能";
            this.btn會員功能.UseVisualStyleBackColor = false;
            this.btn會員功能.Click += new System.EventHandler(this.btn會員功能_Click);
            // 
            // btn結帳單
            // 
            this.btn結帳單.BackColor = System.Drawing.Color.DarkGray;
            this.btn結帳單.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn結帳單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn結帳單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳單.Location = new System.Drawing.Point(0, 178);
            this.btn結帳單.Name = "btn結帳單";
            this.btn結帳單.Size = new System.Drawing.Size(184, 78);
            this.btn結帳單.TabIndex = 4;
            this.btn結帳單.Text = "結帳單";
            this.btn結帳單.UseVisualStyleBackColor = false;
            this.btn結帳單.Click += new System.EventHandler(this.btn結帳單_Click);
            // 
            // btn目錄
            // 
            this.btn目錄.BackColor = System.Drawing.Color.DarkGray;
            this.btn目錄.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn目錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn目錄.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn目錄.Location = new System.Drawing.Point(0, 100);
            this.btn目錄.Name = "btn目錄";
            this.btn目錄.Size = new System.Drawing.Size(184, 78);
            this.btn目錄.TabIndex = 3;
            this.btn目錄.Text = "目錄";
            this.btn目錄.UseVisualStyleBackColor = false;
            this.btn目錄.Click += new System.EventHandler(this.btn目錄_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.lbltitle);
            this.panel3.Location = new System.Drawing.Point(184, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 100);
            this.panel3.TabIndex = 4;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle.Location = new System.Drawing.Point(374, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(94, 35);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Home";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 712);
            this.Controls.Add(this.存放form);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form2";
            this.Text = "訂單系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.存放form.ResumeLayout(false);
            this.存放form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel 存放form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn結帳單;
        private System.Windows.Forms.Button btn目錄;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btn會員功能;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn返回主頁;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn登出;
    }
}