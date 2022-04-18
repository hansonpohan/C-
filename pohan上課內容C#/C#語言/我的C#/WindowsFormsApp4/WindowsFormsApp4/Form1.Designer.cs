
namespace WindowsFormsApp4
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
            this.lblCBV1 = new System.Windows.Forms.Label();
            this.lblCBV2 = new System.Windows.Forms.Label();
            this.lblCBV3 = new System.Windows.Forms.Label();
            this.lblCBR1 = new System.Windows.Forms.Label();
            this.lblCBR2 = new System.Windows.Forms.Label();
            this.lblCBR3 = new System.Windows.Forms.Label();
            this.btnCBV測試 = new System.Windows.Forms.Button();
            this.btnCBR測試 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "傳值呼叫 Call By Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "傳址呼叫 Call By Reference";
            // 
            // lblCBV1
            // 
            this.lblCBV1.AutoSize = true;
            this.lblCBV1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBV1.Location = new System.Drawing.Point(56, 97);
            this.lblCBV1.Name = "lblCBV1";
            this.lblCBV1.Size = new System.Drawing.Size(92, 38);
            this.lblCBV1.TabIndex = 2;
            this.lblCBV1.Text = "CBV1";
            // 
            // lblCBV2
            // 
            this.lblCBV2.AutoSize = true;
            this.lblCBV2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBV2.Location = new System.Drawing.Point(56, 180);
            this.lblCBV2.Name = "lblCBV2";
            this.lblCBV2.Size = new System.Drawing.Size(92, 38);
            this.lblCBV2.TabIndex = 3;
            this.lblCBV2.Text = "CBV2";
            // 
            // lblCBV3
            // 
            this.lblCBV3.AutoSize = true;
            this.lblCBV3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBV3.Location = new System.Drawing.Point(56, 262);
            this.lblCBV3.Name = "lblCBV3";
            this.lblCBV3.Size = new System.Drawing.Size(92, 38);
            this.lblCBV3.TabIndex = 4;
            this.lblCBV3.Text = "CBV3";
            // 
            // lblCBR1
            // 
            this.lblCBR1.AutoSize = true;
            this.lblCBR1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBR1.Location = new System.Drawing.Point(56, 430);
            this.lblCBR1.Name = "lblCBR1";
            this.lblCBR1.Size = new System.Drawing.Size(91, 38);
            this.lblCBR1.TabIndex = 5;
            this.lblCBR1.Text = "CBR1";
            // 
            // lblCBR2
            // 
            this.lblCBR2.AutoSize = true;
            this.lblCBR2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBR2.Location = new System.Drawing.Point(57, 512);
            this.lblCBR2.Name = "lblCBR2";
            this.lblCBR2.Size = new System.Drawing.Size(91, 38);
            this.lblCBR2.TabIndex = 6;
            this.lblCBR2.Text = "CBR2";
            // 
            // lblCBR3
            // 
            this.lblCBR3.AutoSize = true;
            this.lblCBR3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBR3.Location = new System.Drawing.Point(57, 597);
            this.lblCBR3.Name = "lblCBR3";
            this.lblCBR3.Size = new System.Drawing.Size(91, 38);
            this.lblCBR3.TabIndex = 7;
            this.lblCBR3.Text = "CBR3";
            // 
            // btnCBV測試
            // 
            this.btnCBV測試.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCBV測試.Location = new System.Drawing.Point(469, 167);
            this.btnCBV測試.Name = "btnCBV測試";
            this.btnCBV測試.Size = new System.Drawing.Size(254, 64);
            this.btnCBV測試.TabIndex = 8;
            this.btnCBV測試.Text = "CBV測試";
            this.btnCBV測試.UseVisualStyleBackColor = true;
            this.btnCBV測試.Click += new System.EventHandler(this.btnCBV測試_Click);
            // 
            // btnCBR測試
            // 
            this.btnCBR測試.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCBR測試.Location = new System.Drawing.Point(469, 499);
            this.btnCBR測試.Name = "btnCBR測試";
            this.btnCBR測試.Size = new System.Drawing.Size(254, 64);
            this.btnCBR測試.TabIndex = 9;
            this.btnCBR測試.Text = "CBR測試";
            this.btnCBR測試.UseVisualStyleBackColor = true;
            this.btnCBR測試.Click += new System.EventHandler(this.btnCBR測試_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.btnCBR測試);
            this.Controls.Add(this.btnCBV測試);
            this.Controls.Add(this.lblCBR3);
            this.Controls.Add(this.lblCBR2);
            this.Controls.Add(this.lblCBR1);
            this.Controls.Add(this.lblCBV3);
            this.Controls.Add(this.lblCBV2);
            this.Controls.Add(this.lblCBV1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "傳值呼叫與傳址呼叫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCBV1;
        private System.Windows.Forms.Label lblCBV2;
        private System.Windows.Forms.Label lblCBV3;
        private System.Windows.Forms.Label lblCBR1;
        private System.Windows.Forms.Label lblCBR2;
        private System.Windows.Forms.Label lblCBR3;
        private System.Windows.Forms.Button btnCBV測試;
        private System.Windows.Forms.Button btnCBR測試;
    }
}

