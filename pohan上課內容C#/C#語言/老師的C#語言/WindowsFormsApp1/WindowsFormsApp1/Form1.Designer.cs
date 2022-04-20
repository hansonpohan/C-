
namespace WindowsFormsApp1
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
            this.lbl標題 = new System.Windows.Forms.Label();
            this.lbl回應訊息 = new System.Windows.Forms.Label();
            this.btn紅茶 = new System.Windows.Forms.Button();
            this.btn綠茶 = new System.Windows.Forms.Button();
            this.btn奶茶 = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl標題
            // 
            this.lbl標題.AutoSize = true;
            this.lbl標題.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標題.ForeColor = System.Drawing.Color.Blue;
            this.lbl標題.Location = new System.Drawing.Point(266, 26);
            this.lbl標題.Name = "lbl標題";
            this.lbl標題.Size = new System.Drawing.Size(325, 43);
            this.lbl標題.TabIndex = 0;
            this.lbl標題.Text = "冰涼冷飲自動販賣機";
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl回應訊息.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回應訊息.Location = new System.Drawing.Point(12, 82);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(867, 343);
            this.lbl回應訊息.TabIndex = 1;
            this.lbl回應訊息.Text = "回應訊息";
            // 
            // btn紅茶
            // 
            this.btn紅茶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn紅茶.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn紅茶.Location = new System.Drawing.Point(12, 465);
            this.btn紅茶.Name = "btn紅茶";
            this.btn紅茶.Size = new System.Drawing.Size(193, 108);
            this.btn紅茶.TabIndex = 2;
            this.btn紅茶.Text = "紅茶";
            this.btn紅茶.UseVisualStyleBackColor = false;
            this.btn紅茶.Click += new System.EventHandler(this.btn紅茶_Click);
            // 
            // btn綠茶
            // 
            this.btn綠茶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn綠茶.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn綠茶.Location = new System.Drawing.Point(236, 465);
            this.btn綠茶.Name = "btn綠茶";
            this.btn綠茶.Size = new System.Drawing.Size(193, 108);
            this.btn綠茶.TabIndex = 3;
            this.btn綠茶.Text = "綠茶";
            this.btn綠茶.UseVisualStyleBackColor = false;
            this.btn綠茶.Click += new System.EventHandler(this.btn綠茶_Click);
            // 
            // btn奶茶
            // 
            this.btn奶茶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn奶茶.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn奶茶.Location = new System.Drawing.Point(463, 465);
            this.btn奶茶.Name = "btn奶茶";
            this.btn奶茶.Size = new System.Drawing.Size(193, 108);
            this.btn奶茶.TabIndex = 4;
            this.btn奶茶.Text = "奶茶";
            this.btn奶茶.UseVisualStyleBackColor = false;
            this.btn奶茶.Click += new System.EventHandler(this.btn奶茶_Click);
            // 
            // btnCoke
            // 
            this.btnCoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCoke.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCoke.Location = new System.Drawing.Point(686, 465);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(193, 108);
            this.btnCoke.TabIndex = 5;
            this.btnCoke.Text = "可樂";
            this.btnCoke.UseVisualStyleBackColor = false;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(891, 640);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.btn奶茶);
            this.Controls.Add(this.btn綠茶);
            this.Controls.Add(this.btn紅茶);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.lbl標題);
            this.Name = "Form1";
            this.Text = "冷飲自動販賣機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl標題;
        private System.Windows.Forms.Label lbl回應訊息;
        private System.Windows.Forms.Button btn紅茶;
        private System.Windows.Forms.Button btn綠茶;
        private System.Windows.Forms.Button btn奶茶;
        private System.Windows.Forms.Button btnCoke;
    }
}

