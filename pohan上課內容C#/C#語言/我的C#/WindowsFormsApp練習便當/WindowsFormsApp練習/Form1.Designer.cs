
namespace WindowsFormsApp練習
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl資料顯示結果 = new System.Windows.Forms.Label();
            this.btn便當排序 = new System.Windows.Forms.Button();
            this.btn價格排序 = new System.Windows.Forms.Button();
            this.btn列出所有便當 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt便當搜尋 = new System.Windows.Forms.TextBox();
            this.btn便當搜尋 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(318, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "便當店";
            // 
            // lbl資料顯示結果
            // 
            this.lbl資料顯示結果.BackColor = System.Drawing.Color.Coral;
            this.lbl資料顯示結果.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl資料顯示結果.Location = new System.Drawing.Point(36, 90);
            this.lbl資料顯示結果.Name = "lbl資料顯示結果";
            this.lbl資料顯示結果.Size = new System.Drawing.Size(541, 320);
            this.lbl資料顯示結果.TabIndex = 1;
            this.lbl資料顯示結果.Text = "資料顯示結果";
            // 
            // btn便當排序
            // 
            this.btn便當排序.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn便當排序.Location = new System.Drawing.Point(42, 433);
            this.btn便當排序.Name = "btn便當排序";
            this.btn便當排序.Size = new System.Drawing.Size(162, 55);
            this.btn便當排序.TabIndex = 2;
            this.btn便當排序.Text = "便當排序";
            this.btn便當排序.UseVisualStyleBackColor = true;
            this.btn便當排序.Click += new System.EventHandler(this.btn便當排序_Click);
            // 
            // btn價格排序
            // 
            this.btn價格排序.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn價格排序.Location = new System.Drawing.Point(325, 433);
            this.btn價格排序.Name = "btn價格排序";
            this.btn價格排序.Size = new System.Drawing.Size(162, 55);
            this.btn價格排序.TabIndex = 3;
            this.btn價格排序.Text = "價格排序";
            this.btn價格排序.UseVisualStyleBackColor = true;
            this.btn價格排序.Click += new System.EventHandler(this.btn價格排序_Click);
            // 
            // btn列出所有便當
            // 
            this.btn列出所有便當.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列出所有便當.Location = new System.Drawing.Point(42, 509);
            this.btn列出所有便當.Name = "btn列出所有便當";
            this.btn列出所有便當.Size = new System.Drawing.Size(162, 55);
            this.btn列出所有便當.TabIndex = 4;
            this.btn列出所有便當.Text = "列出所有便當";
            this.btn列出所有便當.UseVisualStyleBackColor = true;
            this.btn列出所有便當.Click += new System.EventHandler(this.btn列出所有便當_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.txt便當搜尋);
            this.groupBox1.Controls.Add(this.btn便當搜尋);
            this.groupBox1.Location = new System.Drawing.Point(598, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt便當搜尋
            // 
            this.txt便當搜尋.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt便當搜尋.Location = new System.Drawing.Point(60, 42);
            this.txt便當搜尋.Name = "txt便當搜尋";
            this.txt便當搜尋.Size = new System.Drawing.Size(148, 35);
            this.txt便當搜尋.TabIndex = 7;
            // 
            // btn便當搜尋
            // 
            this.btn便當搜尋.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn便當搜尋.Location = new System.Drawing.Point(60, 103);
            this.btn便當搜尋.Name = "btn便當搜尋";
            this.btn便當搜尋.Size = new System.Drawing.Size(148, 51);
            this.btn便當搜尋.TabIndex = 6;
            this.btn便當搜尋.Text = "便當搜尋";
            this.btn便當搜尋.UseVisualStyleBackColor = true;
            this.btn便當搜尋.Click += new System.EventHandler(this.btn便當搜尋_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(870, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn列出所有便當);
            this.Controls.Add(this.btn價格排序);
            this.Controls.Add(this.btn便當排序);
            this.Controls.Add(this.lbl資料顯示結果);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl資料顯示結果;
        private System.Windows.Forms.Button btn便當排序;
        private System.Windows.Forms.Button btn價格排序;
        private System.Windows.Forms.Button btn列出所有便當;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt便當搜尋;
        private System.Windows.Forms.Button btn便當搜尋;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

