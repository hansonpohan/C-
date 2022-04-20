
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
            this.btn無參數的方法 = new System.Windows.Forms.Button();
            this.btn有參數的方法 = new System.Windows.Forms.Button();
            this.btn回傳值的方法 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn無參數的方法
            // 
            this.btn無參數的方法.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn無參數的方法.Location = new System.Drawing.Point(40, 219);
            this.btn無參數的方法.Name = "btn無參數的方法";
            this.btn無參數的方法.Size = new System.Drawing.Size(274, 59);
            this.btn無參數的方法.TabIndex = 0;
            this.btn無參數的方法.Text = "無參數的方法";
            this.btn無參數的方法.UseVisualStyleBackColor = true;
            this.btn無參數的方法.Click += new System.EventHandler(this.btn無參數的方法_Click);
            // 
            // btn有參數的方法
            // 
            this.btn有參數的方法.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn有參數的方法.Location = new System.Drawing.Point(40, 310);
            this.btn有參數的方法.Name = "btn有參數的方法";
            this.btn有參數的方法.Size = new System.Drawing.Size(274, 59);
            this.btn有參數的方法.TabIndex = 1;
            this.btn有參數的方法.Text = "有參數的方法";
            this.btn有參數的方法.UseVisualStyleBackColor = true;
            this.btn有參數的方法.Click += new System.EventHandler(this.btn有參數的方法_Click);
            // 
            // btn回傳值的方法
            // 
            this.btn回傳值的方法.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回傳值的方法.Location = new System.Drawing.Point(40, 399);
            this.btn回傳值的方法.Name = "btn回傳值的方法";
            this.btn回傳值的方法.Size = new System.Drawing.Size(274, 59);
            this.btn回傳值的方法.TabIndex = 2;
            this.btn回傳值的方法.Text = "回傳值的方法";
            this.btn回傳值的方法.UseVisualStyleBackColor = true;
            this.btn回傳值的方法.Click += new System.EventHandler(this.btn回傳值的方法_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(362, 498);
            this.Controls.Add(this.btn回傳值的方法);
            this.Controls.Add(this.btn有參數的方法);
            this.Controls.Add(this.btn無參數的方法);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn無參數的方法;
        private System.Windows.Forms.Button btn有參數的方法;
        private System.Windows.Forms.Button btn回傳值的方法;
    }
}

