
namespace WindowsFormsApp3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn無參數的方法 = new System.Windows.Forms.Button();
            this.btn有參數的方法 = new System.Windows.Forms.Button();
            this.btn回傳值得方法 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn無參數的方法
            // 
            this.btn無參數的方法.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn無參數的方法.Location = new System.Drawing.Point(120, 165);
            this.btn無參數的方法.Name = "btn無參數的方法";
            this.btn無參數的方法.Size = new System.Drawing.Size(309, 58);
            this.btn無參數的方法.TabIndex = 0;
            this.btn無參數的方法.Text = "無參數的方法";
            this.btn無參數的方法.UseVisualStyleBackColor = true;
            this.btn無參數的方法.Click += new System.EventHandler(this.btn無參數的方法_Click);
            // 
            // btn有參數的方法
            // 
            this.btn有參數的方法.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn有參數的方法.Location = new System.Drawing.Point(120, 264);
            this.btn有參數的方法.Name = "btn有參數的方法";
            this.btn有參數的方法.Size = new System.Drawing.Size(309, 58);
            this.btn有參數的方法.TabIndex = 1;
            this.btn有參數的方法.Text = "有參數的方法";
            this.btn有參數的方法.UseVisualStyleBackColor = true;
            this.btn有參數的方法.Click += new System.EventHandler(this.btn有參數的方法_Click);
            // 
            // btn回傳值得方法
            // 
            this.btn回傳值得方法.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回傳值得方法.Location = new System.Drawing.Point(120, 361);
            this.btn回傳值得方法.Name = "btn回傳值得方法";
            this.btn回傳值得方法.Size = new System.Drawing.Size(309, 58);
            this.btn回傳值得方法.TabIndex = 2;
            this.btn回傳值得方法.Text = "回傳值得方法";
            this.btn回傳值得方法.UseVisualStyleBackColor = true;
            this.btn回傳值得方法.Click += new System.EventHandler(this.btn回傳值得方法_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btn回傳值得方法);
            this.Controls.Add(this.btn有參數的方法);
            this.Controls.Add(this.btn無參數的方法);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn無參數的方法;
        private System.Windows.Forms.Button btn有參數的方法;
        private System.Windows.Forms.Button btn回傳值得方法;
    }
}

