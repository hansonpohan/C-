﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt訂購人電話 = new System.Windows.Forms.TextBox();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.btn加入訂購單 = new System.Windows.Forms.Button();
            this.btn查看訂購單 = new System.Windows.Forms.Button();
            this.lbox冷飲品項 = new System.Windows.Forms.ListBox();
            this.cbox甜度 = new System.Windows.Forms.ComboBox();
            this.cbox冰塊 = new System.Windows.Forms.ComboBox();
            this.checkBox珍珠 = new System.Windows.Forms.CheckBox();
            this.checkBox椰果 = new System.Windows.Forms.CheckBox();
            this.checkBox奶蓋 = new System.Windows.Forms.CheckBox();
            this.checkBox多多布丁 = new System.Windows.Forms.CheckBox();
            this.btn清除 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲店訂購單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂購人(電話)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(52, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "冷飲品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(386, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "甜度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(386, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "冰塊";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(441, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "品項總價";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(283, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "單價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(67, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "數量";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.Khaki;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(272, 438);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(75, 26);
            this.lbl單價.TabIndex = 9;
            this.lbl單價.Text = "XXX元";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.Pink;
            this.lbl品項總價.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(448, 438);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(89, 26);
            this.lbl品項總價.TabIndex = 10;
            this.lbl品項總價.Text = "XXXX元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(130, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 26);
            this.label12.TabIndex = 11;
            this.label12.Text = "杯";
            // 
            // txt訂購人電話
            // 
            this.txt訂購人電話.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人電話.Location = new System.Drawing.Point(57, 85);
            this.txt訂購人電話.Name = "txt訂購人電話";
            this.txt訂購人電話.Size = new System.Drawing.Size(323, 35);
            this.txt訂購人電話.TabIndex = 12;
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(57, 429);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(67, 35);
            this.txt數量.TabIndex = 13;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // btn加入訂購單
            // 
            this.btn加入訂購單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂購單.Location = new System.Drawing.Point(239, 488);
            this.btn加入訂購單.Name = "btn加入訂購單";
            this.btn加入訂購單.Size = new System.Drawing.Size(155, 42);
            this.btn加入訂購單.TabIndex = 14;
            this.btn加入訂購單.Text = "加入訂購單";
            this.btn加入訂購單.UseVisualStyleBackColor = true;
            this.btn加入訂購單.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn查看訂購單
            // 
            this.btn查看訂購單.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看訂購單.Location = new System.Drawing.Point(422, 488);
            this.btn查看訂購單.Name = "btn查看訂購單";
            this.btn查看訂購單.Size = new System.Drawing.Size(146, 42);
            this.btn查看訂購單.TabIndex = 15;
            this.btn查看訂購單.Text = "查看訂購單";
            this.btn查看訂購單.UseVisualStyleBackColor = true;
            this.btn查看訂購單.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // lbox冷飲品項
            // 
            this.lbox冷飲品項.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox冷飲品項.FormattingEnabled = true;
            this.lbox冷飲品項.ItemHeight = 26;
            this.lbox冷飲品項.Location = new System.Drawing.Point(57, 162);
            this.lbox冷飲品項.Name = "lbox冷飲品項";
            this.lbox冷飲品項.Size = new System.Drawing.Size(323, 212);
            this.lbox冷飲品項.TabIndex = 16;
            this.lbox冷飲品項.SelectedIndexChanged += new System.EventHandler(this.lbox冷飲品項_SelectedIndexChanged);
            // 
            // cbox甜度
            // 
            this.cbox甜度.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox甜度.FormattingEnabled = true;
            this.cbox甜度.Location = new System.Drawing.Point(391, 165);
            this.cbox甜度.Name = "cbox甜度";
            this.cbox甜度.Size = new System.Drawing.Size(146, 34);
            this.cbox甜度.TabIndex = 17;
            this.cbox甜度.SelectedIndexChanged += new System.EventHandler(this.cbox甜度_SelectedIndexChanged);
            // 
            // cbox冰塊
            // 
            this.cbox冰塊.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox冰塊.FormattingEnabled = true;
            this.cbox冰塊.Location = new System.Drawing.Point(391, 238);
            this.cbox冰塊.Name = "cbox冰塊";
            this.cbox冰塊.Size = new System.Drawing.Size(146, 34);
            this.cbox冰塊.TabIndex = 18;
            this.cbox冰塊.SelectedIndexChanged += new System.EventHandler(this.cbox冰塊_SelectedIndexChanged);
            // 
            // checkBox珍珠
            // 
            this.checkBox珍珠.AutoSize = true;
            this.checkBox珍珠.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox珍珠.Location = new System.Drawing.Point(391, 308);
            this.checkBox珍珠.Name = "checkBox珍珠";
            this.checkBox珍珠.Size = new System.Drawing.Size(113, 28);
            this.checkBox珍珠.TabIndex = 20;
            this.checkBox珍珠.Text = "珍珠 10元";
            this.checkBox珍珠.UseVisualStyleBackColor = true;
            this.checkBox珍珠.CheckedChanged += new System.EventHandler(this.checkBox珍珠_CheckedChanged);
            // 
            // checkBox椰果
            // 
            this.checkBox椰果.AutoSize = true;
            this.checkBox椰果.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox椰果.Location = new System.Drawing.Point(501, 308);
            this.checkBox椰果.Name = "checkBox椰果";
            this.checkBox椰果.Size = new System.Drawing.Size(113, 28);
            this.checkBox椰果.TabIndex = 21;
            this.checkBox椰果.Text = "椰果 10元";
            this.checkBox椰果.UseVisualStyleBackColor = true;
            this.checkBox椰果.CheckedChanged += new System.EventHandler(this.checkBox椰果_CheckedChanged);
            // 
            // checkBox奶蓋
            // 
            this.checkBox奶蓋.AutoSize = true;
            this.checkBox奶蓋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox奶蓋.Location = new System.Drawing.Point(391, 346);
            this.checkBox奶蓋.Name = "checkBox奶蓋";
            this.checkBox奶蓋.Size = new System.Drawing.Size(113, 28);
            this.checkBox奶蓋.TabIndex = 22;
            this.checkBox奶蓋.Text = "奶蓋 15元";
            this.checkBox奶蓋.UseVisualStyleBackColor = true;
            this.checkBox奶蓋.CheckedChanged += new System.EventHandler(this.checkBox奶蓋_CheckedChanged);
            // 
            // checkBox多多布丁
            // 
            this.checkBox多多布丁.AutoSize = true;
            this.checkBox多多布丁.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox多多布丁.Location = new System.Drawing.Point(501, 346);
            this.checkBox多多布丁.Name = "checkBox多多布丁";
            this.checkBox多多布丁.Size = new System.Drawing.Size(113, 28);
            this.checkBox多多布丁.TabIndex = 23;
            this.checkBox多多布丁.Text = "布丁 20元";
            this.checkBox多多布丁.UseVisualStyleBackColor = true;
            this.checkBox多多布丁.CheckedChanged += new System.EventHandler(this.checkBox多多布丁_CheckedChanged);
            // 
            // btn清除
            // 
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(37, 488);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(146, 42);
            this.btn清除.TabIndex = 28;
            this.btn清除.Text = "清除所有選擇";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(386, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "加料";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(649, 556);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.checkBox多多布丁);
            this.Controls.Add(this.checkBox奶蓋);
            this.Controls.Add(this.checkBox椰果);
            this.Controls.Add(this.checkBox珍珠);
            this.Controls.Add(this.cbox冰塊);
            this.Controls.Add(this.cbox甜度);
            this.Controls.Add(this.lbox冷飲品項);
            this.Controls.Add(this.btn查看訂購單);
            this.Controls.Add(this.btn加入訂購單);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.txt訂購人電話);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "冷飲店訂購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt訂購人電話;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Button btn加入訂購單;
        private System.Windows.Forms.Button btn查看訂購單;
        private System.Windows.Forms.ListBox lbox冷飲品項;
        private System.Windows.Forms.ComboBox cbox甜度;
        private System.Windows.Forms.ComboBox cbox冰塊;
        private System.Windows.Forms.CheckBox checkBox珍珠;
        private System.Windows.Forms.CheckBox checkBox椰果;
        private System.Windows.Forms.CheckBox checkBox奶蓋;
        private System.Windows.Forms.CheckBox checkBox多多布丁;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Label label6;
    }
}

