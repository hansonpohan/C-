
namespace WindowsFormsApp2
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
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelegate
            // 
            this.btnDelegate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelegate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelegate.Location = new System.Drawing.Point(164, 108);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(146, 54);
            this.btnDelegate.TabIndex = 0;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = false;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAction.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAction.Location = new System.Drawing.Point(164, 219);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(146, 54);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFunc.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFunc.Location = new System.Drawing.Point(164, 336);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(146, 54);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = "Func";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnDelegate);
            this.Name = "Form1";
            this.Text = "Delegate委派";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnFunc;
    }
}

