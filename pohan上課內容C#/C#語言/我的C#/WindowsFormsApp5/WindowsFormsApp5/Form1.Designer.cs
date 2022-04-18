
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
            this.lbl資料結果 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl成績總和 = new System.Windows.Forms.Label();
            this.lbl成績平均 = new System.Windows.Forms.Label();
            this.btn姓名排序 = new System.Windows.Forms.Button();
            this.btn成績排序 = new System.Windows.Forms.Button();
            this.btn列出所有學生 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt輸入姓名 = new System.Windows.Forms.TextBox();
            this.btn姓名搜尋 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "學生成績查詢";
            // 
            // lbl資料結果
            // 
            this.lbl資料結果.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl資料結果.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl資料結果.ForeColor = System.Drawing.Color.White;
            this.lbl資料結果.Location = new System.Drawing.Point(42, 72);
            this.lbl資料結果.Name = "lbl資料結果";
            this.lbl資料結果.Size = new System.Drawing.Size(536, 434);
            this.lbl資料結果.TabIndex = 1;
            this.lbl資料結果.Text = "資料結果顯示";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(597, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "成績總和";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "成績平均";
            // 
            // lbl成績總和
            // 
            this.lbl成績總和.AutoSize = true;
            this.lbl成績總和.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl成績總和.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl成績總和.ForeColor = System.Drawing.Color.White;
            this.lbl成績總和.Location = new System.Drawing.Point(629, 352);
            this.lbl成績總和.Name = "lbl成績總和";
            this.lbl成績總和.Size = new System.Drawing.Size(137, 38);
            this.lbl成績總和.TabIndex = 4;
            this.lbl成績總和.Text = "計算結果";
            // 
            // lbl成績平均
            // 
            this.lbl成績平均.AutoSize = true;
            this.lbl成績平均.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl成績平均.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl成績平均.ForeColor = System.Drawing.Color.White;
            this.lbl成績平均.Location = new System.Drawing.Point(629, 455);
            this.lbl成績平均.Name = "lbl成績平均";
            this.lbl成績平均.Size = new System.Drawing.Size(137, 38);
            this.lbl成績平均.TabIndex = 5;
            this.lbl成績平均.Text = "計算結果";
            // 
            // btn姓名排序
            // 
            this.btn姓名排序.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn姓名排序.Location = new System.Drawing.Point(49, 529);
            this.btn姓名排序.Name = "btn姓名排序";
            this.btn姓名排序.Size = new System.Drawing.Size(207, 62);
            this.btn姓名排序.TabIndex = 6;
            this.btn姓名排序.Text = "姓名排序";
            this.btn姓名排序.UseVisualStyleBackColor = true;
            this.btn姓名排序.Click += new System.EventHandler(this.btn姓名排序_Click);
            // 
            // btn成績排序
            // 
            this.btn成績排序.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn成績排序.Location = new System.Drawing.Point(281, 529);
            this.btn成績排序.Name = "btn成績排序";
            this.btn成績排序.Size = new System.Drawing.Size(207, 62);
            this.btn成績排序.TabIndex = 7;
            this.btn成績排序.Text = "成績排序";
            this.btn成績排序.UseVisualStyleBackColor = true;
            this.btn成績排序.Click += new System.EventHandler(this.btn成績排序_Click);
            // 
            // btn列出所有學生
            // 
            this.btn列出所有學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列出所有學生.Location = new System.Drawing.Point(49, 612);
            this.btn列出所有學生.Name = "btn列出所有學生";
            this.btn列出所有學生.Size = new System.Drawing.Size(282, 62);
            this.btn列出所有學生.TabIndex = 8;
            this.btn列出所有學生.Text = "列出所有學生";
            this.btn列出所有學生.UseVisualStyleBackColor = true;
            this.btn列出所有學生.Click += new System.EventHandler(this.btn列出所有學生_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn姓名搜尋);
            this.groupBox1.Controls.Add(this.txt輸入姓名);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(544, 529);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋功能";
            // 
            // txt輸入姓名
            // 
            this.txt輸入姓名.Location = new System.Drawing.Point(32, 42);
            this.txt輸入姓名.Name = "txt輸入姓名";
            this.txt輸入姓名.Size = new System.Drawing.Size(210, 43);
            this.txt輸入姓名.TabIndex = 0;
            // 
            // btn姓名搜尋
            // 
            this.btn姓名搜尋.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn姓名搜尋.ForeColor = System.Drawing.Color.Black;
            this.btn姓名搜尋.Location = new System.Drawing.Point(45, 91);
            this.btn姓名搜尋.Name = "btn姓名搜尋";
            this.btn姓名搜尋.Size = new System.Drawing.Size(181, 53);
            this.btn姓名搜尋.TabIndex = 1;
            this.btn姓名搜尋.Text = "姓名搜尋";
            this.btn姓名搜尋.UseVisualStyleBackColor = true;
            this.btn姓名搜尋.Click += new System.EventHandler(this.btn姓名搜尋_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(853, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn列出所有學生);
            this.Controls.Add(this.btn成績排序);
            this.Controls.Add(this.btn姓名排序);
            this.Controls.Add(this.lbl成績平均);
            this.Controls.Add(this.lbl成績總和);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl資料結果);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Array的進階應用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl資料結果;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl成績總和;
        private System.Windows.Forms.Label lbl成績平均;
        private System.Windows.Forms.Button btn姓名排序;
        private System.Windows.Forms.Button btn成績排序;
        private System.Windows.Forms.Button btn列出所有學生;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn姓名搜尋;
        private System.Windows.Forms.TextBox txt輸入姓名;
    }
}

