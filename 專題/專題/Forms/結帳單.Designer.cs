
namespace 專題.Forms
{
    partial class 結帳單
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
            this.btn修改訂單 = new System.Windows.Forms.Button();
            this.btn結帳 = new System.Windows.Forms.Button();
            this.btn儲存訂單 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl會員名稱 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn修改訂單
            // 
            this.btn修改訂單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改訂單.Location = new System.Drawing.Point(627, 487);
            this.btn修改訂單.Name = "btn修改訂單";
            this.btn修改訂單.Size = new System.Drawing.Size(149, 51);
            this.btn修改訂單.TabIndex = 21;
            this.btn修改訂單.Text = "修改訂單";
            this.btn修改訂單.UseVisualStyleBackColor = true;
            this.btn修改訂單.Click += new System.EventHandler(this.btn修改訂單_Click);
            // 
            // btn結帳
            // 
            this.btn結帳.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.Location = new System.Drawing.Point(544, 564);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(149, 43);
            this.btn結帳.TabIndex = 19;
            this.btn結帳.Text = "下單";
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // btn儲存訂單
            // 
            this.btn儲存訂單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存訂單.Location = new System.Drawing.Point(461, 488);
            this.btn儲存訂單.Name = "btn儲存訂單";
            this.btn儲存訂單.Size = new System.Drawing.Size(149, 50);
            this.btn儲存訂單.TabIndex = 17;
            this.btn儲存訂單.Text = "儲存訂單";
            this.btn儲存訂單.UseVisualStyleBackColor = true;
            this.btn儲存訂單.Click += new System.EventHandler(this.btn儲存訂單_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(194, 470);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(149, 51);
            this.btn清除所有品項.TabIndex = 16;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(26, 470);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(149, 51);
            this.btn移除所選品項.TabIndex = 15;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(576, 427);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(200, 26);
            this.lbl訂單總價.TabIndex = 14;
            this.lbl訂單總價.Text = "訂單總價:XXXXX元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(336, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "訂購品項列表";
            // 
            // lbox訂購品項列表
            // 
            this.lbox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂購品項列表.FormattingEnabled = true;
            this.lbox訂購品項列表.ItemHeight = 21;
            this.lbox訂購品項列表.Location = new System.Drawing.Point(26, 147);
            this.lbox訂購品項列表.Name = "lbox訂購品項列表";
            this.lbox訂購品項列表.Size = new System.Drawing.Size(750, 256);
            this.lbox訂購品項列表.TabIndex = 11;
            this.lbox訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.lbox訂購品項列表_SelectedIndexChanged);
            // 
            // lbl會員名稱
            // 
            this.lbl會員名稱.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl會員名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員名稱.Location = new System.Drawing.Point(494, 83);
            this.lbl會員名稱.Name = "lbl會員名稱";
            this.lbl會員名稱.Size = new System.Drawing.Size(282, 25);
            this.lbl會員名稱.TabIndex = 12;
            this.lbl會員名稱.Text = "會員名稱:";
            // 
            // 結帳單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(801, 639);
            this.Controls.Add(this.btn修改訂單);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.btn儲存訂單);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl會員名稱);
            this.Controls.Add(this.lbox訂購品項列表);
            this.Name = "結帳單";
            this.Text = "結帳單";
            this.Load += new System.EventHandler(this.結帳單_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn修改訂單;
        private System.Windows.Forms.Button btn結帳;
        private System.Windows.Forms.Button btn儲存訂單;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbox訂購品項列表;
        private System.Windows.Forms.Label lbl會員名稱;
    }
}