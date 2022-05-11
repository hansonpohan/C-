
namespace WindowsFormsApp1
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
            this.btn創建員工1 = new System.Windows.Forms.Button();
            this.btn創建員工2 = new System.Windows.Forms.Button();
            this.btn列出所有員工 = new System.Windows.Forms.Button();
            this.btn創建管理者1 = new System.Windows.Forms.Button();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn創建員工1
            // 
            this.btn創建員工1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn創建員工1.Location = new System.Drawing.Point(122, 214);
            this.btn創建員工1.Name = "btn創建員工1";
            this.btn創建員工1.Size = new System.Drawing.Size(282, 69);
            this.btn創建員工1.TabIndex = 0;
            this.btn創建員工1.Text = "創建員工1";
            this.btn創建員工1.UseVisualStyleBackColor = true;
            this.btn創建員工1.Click += new System.EventHandler(this.btn創建員工1_Click);
            // 
            // btn創建員工2
            // 
            this.btn創建員工2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn創建員工2.Location = new System.Drawing.Point(122, 306);
            this.btn創建員工2.Name = "btn創建員工2";
            this.btn創建員工2.Size = new System.Drawing.Size(282, 69);
            this.btn創建員工2.TabIndex = 1;
            this.btn創建員工2.Text = "創建員工2";
            this.btn創建員工2.UseVisualStyleBackColor = true;
            this.btn創建員工2.Click += new System.EventHandler(this.btn創建員工2_Click);
            // 
            // btn列出所有員工
            // 
            this.btn列出所有員工.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列出所有員工.Location = new System.Drawing.Point(122, 402);
            this.btn列出所有員工.Name = "btn列出所有員工";
            this.btn列出所有員工.Size = new System.Drawing.Size(282, 69);
            this.btn列出所有員工.TabIndex = 2;
            this.btn列出所有員工.Text = "列出所有員工";
            this.btn列出所有員工.UseVisualStyleBackColor = true;
            this.btn列出所有員工.Click += new System.EventHandler(this.btn列出所有員工_Click);
            // 
            // btn創建管理者1
            // 
            this.btn創建管理者1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn創建管理者1.Location = new System.Drawing.Point(122, 499);
            this.btn創建管理者1.Name = "btn創建管理者1";
            this.btn創建管理者1.Size = new System.Drawing.Size(282, 69);
            this.btn創建管理者1.TabIndex = 3;
            this.btn創建管理者1.Text = "創建管理者1";
            this.btn創建管理者1.UseVisualStyleBackColor = true;
            this.btn創建管理者1.Click += new System.EventHandler(this.btn創建管理者1_Click);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoginName.Location = new System.Drawing.Point(312, 9);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(112, 25);
            this.lblLoginName.TabIndex = 4;
            this.lblLoginName.Text = "登入者名稱";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(527, 656);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.btn創建管理者1);
            this.Controls.Add(this.btn列出所有員工);
            this.Controls.Add(this.btn創建員工2);
            this.Controls.Add(this.btn創建員工1);
            this.Name = "Form1";
            this.Text = "Class的實作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn創建員工1;
        private System.Windows.Forms.Button btn創建員工2;
        private System.Windows.Forms.Button btn列出所有員工;
        private System.Windows.Forms.Button btn創建管理者1;
        private System.Windows.Forms.Label lblLoginName;
    }
}

