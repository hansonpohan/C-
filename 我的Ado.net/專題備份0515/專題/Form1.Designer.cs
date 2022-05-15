
namespace 專題
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn註冊帳號 = new System.Windows.Forms.Button();
            this.btn登入系統 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.存放form = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn註冊帳號);
            this.panel1.Controls.Add(this.btn登入系統);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 644);
            this.panel1.TabIndex = 0;
            // 
            // btn註冊帳號
            // 
            this.btn註冊帳號.BackColor = System.Drawing.Color.DarkGray;
            this.btn註冊帳號.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn註冊帳號.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn註冊帳號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊帳號.Location = new System.Drawing.Point(0, 178);
            this.btn註冊帳號.Name = "btn註冊帳號";
            this.btn註冊帳號.Size = new System.Drawing.Size(184, 78);
            this.btn註冊帳號.TabIndex = 2;
            this.btn註冊帳號.Text = "註冊帳號";
            this.btn註冊帳號.UseVisualStyleBackColor = false;
            this.btn註冊帳號.Click += new System.EventHandler(this.btn註冊帳號_Click);
            // 
            // btn登入系統
            // 
            this.btn登入系統.BackColor = System.Drawing.Color.DarkGray;
            this.btn登入系統.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn登入系統.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登入系統.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入系統.Location = new System.Drawing.Point(0, 100);
            this.btn登入系統.Name = "btn登入系統";
            this.btn登入系統.Size = new System.Drawing.Size(184, 78);
            this.btn登入系統.TabIndex = 1;
            this.btn登入系統.Text = "登入系統";
            this.btn登入系統.UseVisualStyleBackColor = false;
            this.btn登入系統.Click += new System.EventHandler(this.btn登入系統_Click);
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
            this.panel3.Location = new System.Drawing.Point(183, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 100);
            this.panel3.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle.Location = new System.Drawing.Point(372, 27);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(94, 35);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Home";
            // 
            // 存放form
            // 
            this.存放form.Location = new System.Drawing.Point(183, 101);
            this.存放form.Name = "存放form";
            this.存放form.Size = new System.Drawing.Size(868, 542);
            this.存放form.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 642);
            this.Controls.Add(this.存放form);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn註冊帳號;
        private System.Windows.Forms.Button btn登入系統;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel 存放form;
        private System.Windows.Forms.Label lbltitle;
    }
}

