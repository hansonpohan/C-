
namespace 專題.Forms
{
    partial class 目錄
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
            this.lbox手機型號 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox顏色 = new System.Windows.Forms.ComboBox();
            this.cbox容量 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.btn清除 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbox手機型號
            // 
            this.lbox手機型號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox手機型號.FormattingEnabled = true;
            this.lbox手機型號.ItemHeight = 24;
            this.lbox手機型號.Location = new System.Drawing.Point(12, 29);
            this.lbox手機型號.Name = "lbox手機型號";
            this.lbox手機型號.Size = new System.Drawing.Size(399, 412);
            this.lbox手機型號.TabIndex = 5;
            this.lbox手機型號.SelectedIndexChanged += new System.EventHandler(this.lbox手機型號_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(461, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "顏色";
            // 
            // cbox顏色
            // 
            this.cbox顏色.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox顏色.FormattingEnabled = true;
            this.cbox顏色.Location = new System.Drawing.Point(426, 143);
            this.cbox顏色.Name = "cbox顏色";
            this.cbox顏色.Size = new System.Drawing.Size(121, 29);
            this.cbox顏色.TabIndex = 11;
            this.cbox顏色.SelectedIndexChanged += new System.EventHandler(this.cbox顏色_SelectedIndexChanged);
            // 
            // cbox容量
            // 
            this.cbox容量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox容量.FormattingEnabled = true;
            this.cbox容量.Location = new System.Drawing.Point(426, 310);
            this.cbox容量.Name = "cbox容量";
            this.cbox容量.Size = new System.Drawing.Size(162, 29);
            this.cbox容量.TabIndex = 13;
            this.cbox容量.SelectedIndexChanged += new System.EventHandler(this.cbox容量_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(461, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "容量";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(307, 546);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(140, 45);
            this.btn加入購物車.TabIndex = 15;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(66, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "數量";
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(62, 496);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(52, 33);
            this.txt數量.TabIndex = 18;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(120, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "支";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(258, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "單價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(422, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "總價";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(258, 499);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(107, 24);
            this.lbl單價.TabIndex = 22;
            this.lbl單價.Text = "XXXXXX元";
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(422, 499);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(120, 24);
            this.lbl總價.TabIndex = 24;
            this.lbl總價.Text = "XXXXXXX元";
            // 
            // btn清除
            // 
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(44, 546);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(140, 45);
            this.btn清除.TabIndex = 25;
            this.btn清除.Text = "清除所有選擇";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::專題.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(618, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::專題.Properties.Resources.三星;
            this.pictureBox1.Location = new System.Drawing.Point(618, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // 目錄
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(897, 631);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.cbox容量);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox顏色);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbox手機型號);
            this.Name = "目錄";
            this.Text = "目錄";
            this.Load += new System.EventHandler(this.目錄_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbox手機型號;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox顏色;
        private System.Windows.Forms.ComboBox cbox容量;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}