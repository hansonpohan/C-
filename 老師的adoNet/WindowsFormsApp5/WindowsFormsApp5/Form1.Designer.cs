
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn重新載入 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 8);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 419);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.Location = new System.Drawing.Point(413, 230);
            this.btn圖片模式.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(112, 41);
            this.btn圖片模式.TabIndex = 1;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = true;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.Location = new System.Drawing.Point(413, 282);
            this.btn列表模式.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(112, 41);
            this.btn列表模式.TabIndex = 2;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = true;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.Location = new System.Drawing.Point(413, 334);
            this.btn新增商品.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(112, 41);
            this.btn新增商品.TabIndex = 3;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = true;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn重新載入
            // 
            this.btn重新載入.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新載入.Location = new System.Drawing.Point(413, 385);
            this.btn重新載入.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn重新載入.Name = "btn重新載入";
            this.btn重新載入.Size = new System.Drawing.Size(112, 41);
            this.btn重新載入.TabIndex = 4;
            this.btn重新載入.Text = "重新載入";
            this.btn重新載入.UseVisualStyleBackColor = true;
            this.btn重新載入.Click += new System.EventHandler(this.btn重新載入_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(533, 433);
            this.Controls.Add(this.btn重新載入);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "商品資料庫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn重新載入;
        private System.Windows.Forms.ImageList imageList1;
    }
}

