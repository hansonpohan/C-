
namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購人資料 = new System.Windows.Forms.Label();
            this.lbox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.radioDiscount1 = new System.Windows.Forms.RadioButton();
            this.radioDiscount2 = new System.Windows.Forms.RadioButton();
            this.radioDiscount3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲訂購品項列表";
            // 
            // lbl訂購人資料
            // 
            this.lbl訂購人資料.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl訂購人資料.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資料.Location = new System.Drawing.Point(340, 83);
            this.lbl訂購人資料.Name = "lbl訂購人資料";
            this.lbl訂購人資料.Size = new System.Drawing.Size(490, 26);
            this.lbl訂購人資料.TabIndex = 1;
            this.lbl訂購人資料.Text = "訂購人資料";
            // 
            // lbox訂購品項列表
            // 
            this.lbox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂購品項列表.FormattingEnabled = true;
            this.lbox訂購品項列表.ItemHeight = 24;
            this.lbox訂購品項列表.Location = new System.Drawing.Point(12, 122);
            this.lbox訂購品項列表.Name = "lbox訂購品項列表";
            this.lbox訂購品項列表.Size = new System.Drawing.Size(818, 268);
            this.lbox訂購品項列表.TabIndex = 2;
            this.lbox訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.lbox訂購品項列表_SelectedIndexChanged);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(603, 418);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(199, 26);
            this.lbl訂單總價.TabIndex = 3;
            this.lbl訂單總價.Text = "訂單總價 XXXXX元";
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(473, 471);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(154, 49);
            this.btn移除所選品項.TabIndex = 4;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(649, 471);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(154, 49);
            this.btn清除所有品項.TabIndex = 5;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkTax.Location = new System.Drawing.Point(470, 418);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(133, 28);
            this.chkTax.TabIndex = 6;
            this.chkTax.Text = "加入5%稅金";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.CheckedChanged += new System.EventHandler(this.chkTax_CheckedChanged);
            // 
            // radioDiscount1
            // 
            this.radioDiscount1.AutoSize = true;
            this.radioDiscount1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount1.Location = new System.Drawing.Point(31, 35);
            this.radioDiscount1.Name = "radioDiscount1";
            this.radioDiscount1.Size = new System.Drawing.Size(114, 30);
            this.radioDiscount1.TabIndex = 7;
            this.radioDiscount1.TabStop = true;
            this.radioDiscount1.Text = "買二折一";
            this.radioDiscount1.UseVisualStyleBackColor = true;
            this.radioDiscount1.CheckedChanged += new System.EventHandler(this.radioDiscount1_CheckedChanged);
            // 
            // radioDiscount2
            // 
            this.radioDiscount2.AutoSize = true;
            this.radioDiscount2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount2.Location = new System.Drawing.Point(31, 71);
            this.radioDiscount2.Name = "radioDiscount2";
            this.radioDiscount2.Size = new System.Drawing.Size(114, 30);
            this.radioDiscount2.TabIndex = 8;
            this.radioDiscount2.TabStop = true;
            this.radioDiscount2.Text = "買三折一";
            this.radioDiscount2.UseVisualStyleBackColor = true;
            this.radioDiscount2.CheckedChanged += new System.EventHandler(this.radioDiscount2_CheckedChanged);
            // 
            // radioDiscount3
            // 
            this.radioDiscount3.AutoSize = true;
            this.radioDiscount3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount3.Location = new System.Drawing.Point(31, 107);
            this.radioDiscount3.Name = "radioDiscount3";
            this.radioDiscount3.Size = new System.Drawing.Size(135, 30);
            this.radioDiscount3.TabIndex = 9;
            this.radioDiscount3.TabStop = true;
            this.radioDiscount3.Text = "第二件半價";
            this.radioDiscount3.UseVisualStyleBackColor = true;
            this.radioDiscount3.CheckedChanged += new System.EventHandler(this.radioDiscount3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.radioDiscount1);
            this.groupBox1.Controls.Add(this.radioDiscount3);
            this.groupBox1.Controls.Add(this.radioDiscount2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(61, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 155);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣活動(以最低價優先)";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(649, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 39);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "關閉表單";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsave.Location = new System.Drawing.Point(473, 544);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(153, 39);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "儲存訂單txt";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(859, 601);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTax);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.lbox訂購品項列表);
            this.Controls.Add(this.lbl訂購人資料);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "結帳單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購人資料;
        private System.Windows.Forms.ListBox lbox訂購品項列表;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.RadioButton radioDiscount1;
        private System.Windows.Forms.RadioButton radioDiscount2;
        private System.Windows.Forms.RadioButton radioDiscount3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnsave;
    }
}