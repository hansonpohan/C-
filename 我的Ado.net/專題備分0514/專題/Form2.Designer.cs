
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn會員功能 = new System.Windows.Forms.Button();
            this.btn結帳單 = new System.Windows.Forms.Button();
            this.btn目錄 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 存放form
            // 
            this.存放form.Location = new System.Drawing.Point(184, 97);
            this.存放form.Name = "存放form";
            this.存放form.Size = new System.Drawing.Size(868, 703);
            this.存放form.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn會員功能);
            this.panel1.Controls.Add(this.btn結帳單);
            this.panel1.Controls.Add(this.btn目錄);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 805);
            this.panel1.TabIndex = 3;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 100);
            this.panel2.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(1051, 799);
            this.Controls.Add(this.存放form);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel 存放form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn結帳單;
        private System.Windows.Forms.Button btn目錄;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btn會員功能;
    }
}