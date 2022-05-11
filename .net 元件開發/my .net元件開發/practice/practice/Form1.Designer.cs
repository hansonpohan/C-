
namespace practice
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
            this.btn創建員工 = new System.Windows.Forms.Button();
            this.btn創建主管 = new System.Windows.Forms.Button();
            this.btn列出所有員工 = new System.Windows.Forms.Button();
            this.btn列出所有主管 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn創建員工
            // 
            this.btn創建員工.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn創建員工.Location = new System.Drawing.Point(208, 84);
            this.btn創建員工.Name = "btn創建員工";
            this.btn創建員工.Size = new System.Drawing.Size(183, 61);
            this.btn創建員工.TabIndex = 0;
            this.btn創建員工.Text = "創建員工";
            this.btn創建員工.UseVisualStyleBackColor = true;
            this.btn創建員工.Click += new System.EventHandler(this.btn創建員工_Click);
            // 
            // btn創建主管
            // 
            this.btn創建主管.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn創建主管.Location = new System.Drawing.Point(208, 193);
            this.btn創建主管.Name = "btn創建主管";
            this.btn創建主管.Size = new System.Drawing.Size(183, 61);
            this.btn創建主管.TabIndex = 1;
            this.btn創建主管.Text = "創建主管";
            this.btn創建主管.UseVisualStyleBackColor = true;
            this.btn創建主管.Click += new System.EventHandler(this.btn創建主管_Click);
            // 
            // btn列出所有員工
            // 
            this.btn列出所有員工.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列出所有員工.Location = new System.Drawing.Point(208, 299);
            this.btn列出所有員工.Name = "btn列出所有員工";
            this.btn列出所有員工.Size = new System.Drawing.Size(183, 61);
            this.btn列出所有員工.TabIndex = 2;
            this.btn列出所有員工.Text = "列出所有員工";
            this.btn列出所有員工.UseVisualStyleBackColor = true;
            this.btn列出所有員工.Click += new System.EventHandler(this.btn列出所有員工_Click);
            // 
            // btn列出所有主管
            // 
            this.btn列出所有主管.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列出所有主管.Location = new System.Drawing.Point(208, 413);
            this.btn列出所有主管.Name = "btn列出所有主管";
            this.btn列出所有主管.Size = new System.Drawing.Size(183, 61);
            this.btn列出所有主管.TabIndex = 3;
            this.btn列出所有主管.Text = "列出所有主管";
            this.btn列出所有主管.UseVisualStyleBackColor = true;
            this.btn列出所有主管.Click += new System.EventHandler(this.btn列出所有主管_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 564);
            this.Controls.Add(this.btn列出所有主管);
            this.Controls.Add(this.btn列出所有員工);
            this.Controls.Add(this.btn創建主管);
            this.Controls.Add(this.btn創建員工);
            this.Name = "Form1";
            this.Text = "員工創建";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn創建員工;
        private System.Windows.Forms.Button btn創建主管;
        private System.Windows.Forms.Button btn列出所有員工;
        private System.Windows.Forms.Button btn列出所有主管;
    }
}

