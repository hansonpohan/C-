
namespace WindowsFormsApp5
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
            this.lbl資料結果顯示 = new System.Windows.Forms.Label();
            this.lbl成績總和 = new System.Windows.Forms.Label();
            this.lbl成績平均 = new System.Windows.Forms.Label();
            this.lbl計算結果 = new System.Windows.Forms.Label();
            this.lbl計算結果2 = new System.Windows.Forms.Label();
            this.btn姓名排序 = new System.Windows.Forms.Button();
            this.btn成績排序 = new System.Windows.Forms.Button();
            this.btn列出所有學生 = new System.Windows.Forms.Button();
            this.gru搜尋功能 = new System.Windows.Forms.GroupBox();
            this.txt姓名搜尋 = new System.Windows.Forms.TextBox();
            this.btn姓名搜尋 = new System.Windows.Forms.Button();
            this.gru搜尋功能.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "學生成績查詢";
            // 
            // lbl資料結果顯示
            // 
            this.lbl資料結果顯示.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl資料結果顯示.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl資料結果顯示.ForeColor = System.Drawing.Color.White;
            this.lbl資料結果顯示.Location = new System.Drawing.Point(21, 78);
            this.lbl資料結果顯示.Name = "lbl資料結果顯示";
            this.lbl資料結果顯示.Size = new System.Drawing.Size(455, 298);
            this.lbl資料結果顯示.TabIndex = 1;
            this.lbl資料結果顯示.Text = "資料結果顯示";
            // 
            // lbl成績總和
            // 
            this.lbl成績總和.AutoSize = true;
            this.lbl成績總和.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl成績總和.ForeColor = System.Drawing.Color.White;
            this.lbl成績總和.Location = new System.Drawing.Point(498, 194);
            this.lbl成績總和.Name = "lbl成績總和";
            this.lbl成績總和.Size = new System.Drawing.Size(110, 31);
            this.lbl成績總和.TabIndex = 2;
            this.lbl成績總和.Text = "成績總和";
            // 
            // lbl成績平均
            // 
            this.lbl成績平均.AutoSize = true;
            this.lbl成績平均.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl成績平均.ForeColor = System.Drawing.Color.White;
            this.lbl成績平均.Location = new System.Drawing.Point(498, 304);
            this.lbl成績平均.Name = "lbl成績平均";
            this.lbl成績平均.Size = new System.Drawing.Size(110, 31);
            this.lbl成績平均.TabIndex = 3;
            this.lbl成績平均.Text = "成績平均";
            // 
            // lbl計算結果
            // 
            this.lbl計算結果.AutoSize = true;
            this.lbl計算結果.BackColor = System.Drawing.Color.DarkGreen;
            this.lbl計算結果.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl計算結果.ForeColor = System.Drawing.Color.White;
            this.lbl計算結果.Location = new System.Drawing.Point(513, 241);
            this.lbl計算結果.Name = "lbl計算結果";
            this.lbl計算結果.Size = new System.Drawing.Size(110, 31);
            this.lbl計算結果.TabIndex = 4;
            this.lbl計算結果.Text = "計算結果";
            // 
            // lbl計算結果2
            // 
            this.lbl計算結果2.AutoSize = true;
            this.lbl計算結果2.BackColor = System.Drawing.Color.DarkGreen;
            this.lbl計算結果2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl計算結果2.ForeColor = System.Drawing.Color.White;
            this.lbl計算結果2.Location = new System.Drawing.Point(513, 346);
            this.lbl計算結果2.Name = "lbl計算結果2";
            this.lbl計算結果2.Size = new System.Drawing.Size(110, 31);
            this.lbl計算結果2.TabIndex = 5;
            this.lbl計算結果2.Text = "計算結果";
            // 
            // btn姓名排序
            // 
            this.btn姓名排序.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn姓名排序.Location = new System.Drawing.Point(27, 387);
            this.btn姓名排序.Name = "btn姓名排序";
            this.btn姓名排序.Size = new System.Drawing.Size(146, 48);
            this.btn姓名排序.TabIndex = 6;
            this.btn姓名排序.Text = "姓名排序";
            this.btn姓名排序.UseVisualStyleBackColor = true;
            this.btn姓名排序.Click += new System.EventHandler(this.btn姓名排序_Click);
            // 
            // btn成績排序
            // 
            this.btn成績排序.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn成績排序.Location = new System.Drawing.Point(242, 387);
            this.btn成績排序.Name = "btn成績排序";
            this.btn成績排序.Size = new System.Drawing.Size(146, 48);
            this.btn成績排序.TabIndex = 7;
            this.btn成績排序.Text = "成績排序";
            this.btn成績排序.UseVisualStyleBackColor = true;
            this.btn成績排序.Click += new System.EventHandler(this.btn成績排序_Click);
            // 
            // btn列出所有學生
            // 
            this.btn列出所有學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列出所有學生.Location = new System.Drawing.Point(27, 448);
            this.btn列出所有學生.Name = "btn列出所有學生";
            this.btn列出所有學生.Size = new System.Drawing.Size(193, 48);
            this.btn列出所有學生.TabIndex = 8;
            this.btn列出所有學生.Text = "列出所有學生";
            this.btn列出所有學生.UseVisualStyleBackColor = true;
            this.btn列出所有學生.Click += new System.EventHandler(this.btn列出所有學生_Click);
            // 
            // gru搜尋功能
            // 
            this.gru搜尋功能.Controls.Add(this.btn姓名搜尋);
            this.gru搜尋功能.Controls.Add(this.txt姓名搜尋);
            this.gru搜尋功能.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gru搜尋功能.ForeColor = System.Drawing.Color.White;
            this.gru搜尋功能.Location = new System.Drawing.Point(418, 389);
            this.gru搜尋功能.Name = "gru搜尋功能";
            this.gru搜尋功能.Size = new System.Drawing.Size(205, 118);
            this.gru搜尋功能.TabIndex = 9;
            this.gru搜尋功能.TabStop = false;
            this.gru搜尋功能.Text = "搜尋功能";
            // 
            // txt姓名搜尋
            // 
            this.txt姓名搜尋.Location = new System.Drawing.Point(27, 30);
            this.txt姓名搜尋.Name = "txt姓名搜尋";
            this.txt姓名搜尋.Size = new System.Drawing.Size(163, 35);
            this.txt姓名搜尋.TabIndex = 0;
            // 
            // btn姓名搜尋
            // 
            this.btn姓名搜尋.ForeColor = System.Drawing.Color.Black;
            this.btn姓名搜尋.Location = new System.Drawing.Point(44, 72);
            this.btn姓名搜尋.Name = "btn姓名搜尋";
            this.btn姓名搜尋.Size = new System.Drawing.Size(126, 35);
            this.btn姓名搜尋.TabIndex = 1;
            this.btn姓名搜尋.Text = "姓名搜尋";
            this.btn姓名搜尋.UseVisualStyleBackColor = true;
            this.btn姓名搜尋.Click += new System.EventHandler(this.btn姓名搜尋_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(666, 531);
            this.Controls.Add(this.gru搜尋功能);
            this.Controls.Add(this.btn列出所有學生);
            this.Controls.Add(this.btn成績排序);
            this.Controls.Add(this.btn姓名排序);
            this.Controls.Add(this.lbl計算結果2);
            this.Controls.Add(this.lbl計算結果);
            this.Controls.Add(this.lbl成績平均);
            this.Controls.Add(this.lbl成績總和);
            this.Controls.Add(this.lbl資料結果顯示);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Array的進階應用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gru搜尋功能.ResumeLayout(false);
            this.gru搜尋功能.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl資料結果顯示;
        private System.Windows.Forms.Label lbl成績總和;
        private System.Windows.Forms.Label lbl成績平均;
        private System.Windows.Forms.Label lbl計算結果;
        private System.Windows.Forms.Label lbl計算結果2;
        private System.Windows.Forms.Button btn姓名排序;
        private System.Windows.Forms.Button btn成績排序;
        private System.Windows.Forms.Button btn列出所有學生;
        private System.Windows.Forms.GroupBox gru搜尋功能;
        private System.Windows.Forms.Button btn姓名搜尋;
        private System.Windows.Forms.TextBox txt姓名搜尋;
    }
}

