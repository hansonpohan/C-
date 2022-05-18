
namespace WindowsFormsApp6
{
    partial class MyUserControlOne
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl標籤標題 = new System.Windows.Forms.Label();
            this.txt輸入文字 = new System.Windows.Forms.TextBox();
            this.btn更改標題 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl標籤標題
            // 
            this.lbl標籤標題.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl標籤標題.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標籤標題.Location = new System.Drawing.Point(23, 19);
            this.lbl標籤標題.Name = "lbl標籤標題";
            this.lbl標籤標題.Size = new System.Drawing.Size(279, 46);
            this.lbl標籤標題.TabIndex = 0;
            this.lbl標籤標題.Text = "標籤標題";
            this.lbl標籤標題.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt輸入文字
            // 
            this.txt輸入文字.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt輸入文字.Location = new System.Drawing.Point(29, 89);
            this.txt輸入文字.Name = "txt輸入文字";
            this.txt輸入文字.Size = new System.Drawing.Size(214, 45);
            this.txt輸入文字.TabIndex = 1;
            // 
            // btn更改標題
            // 
            this.btn更改標題.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn更改標題.Location = new System.Drawing.Point(263, 89);
            this.btn更改標題.Name = "btn更改標題";
            this.btn更改標題.Size = new System.Drawing.Size(174, 62);
            this.btn更改標題.TabIndex = 2;
            this.btn更改標題.Text = "更改標題";
            this.btn更改標題.UseVisualStyleBackColor = true;
            this.btn更改標題.Click += new System.EventHandler(this.btn更改標題_Click);
            // 
            // MyUserControlOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.btn更改標題);
            this.Controls.Add(this.txt輸入文字);
            this.Controls.Add(this.lbl標籤標題);
            this.Name = "MyUserControlOne";
            this.Size = new System.Drawing.Size(457, 167);
            this.Load += new System.EventHandler(this.MyUserControlOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl標籤標題;
        public System.Windows.Forms.TextBox txt輸入文字;
        public System.Windows.Forms.Button btn更改標題;
    }
}
