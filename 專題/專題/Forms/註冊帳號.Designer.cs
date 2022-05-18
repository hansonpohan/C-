
namespace 專題.Forms
{
    partial class 註冊帳號
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.會員BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet2 = new 專題.mydbDataSet2();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.會員TableAdapter = new 專題.mydbDataSet2TableAdapters.會員TableAdapter();
            this.tableAdapterManager = new 專題.mydbDataSet2TableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.帳號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk員工註冊 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk員工註冊);
            this.groupBox1.Controls.Add(this.txt密碼);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt帳號);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "帳號註冊";
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(77, 124);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(204, 33);
            this.txt密碼.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // txt帳號
            // 
            this.txt帳號.Location = new System.Drawing.Point(77, 49);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(204, 33);
            this.txt帳號.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // 會員BindingSource
            // 
            this.會員BindingSource.DataMember = "會員";
            this.會員BindingSource.DataSource = this.mydbDataSet2;
            // 
            // mydbDataSet2
            // 
            this.mydbDataSet2.DataSetName = "mydbDataSet2";
            this.mydbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn儲存
            // 
            this.btn儲存.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存.Location = new System.Drawing.Point(117, 288);
            this.btn儲存.Name = "btn儲存";
            this.btn儲存.Size = new System.Drawing.Size(106, 43);
            this.btn儲存.TabIndex = 9;
            this.btn儲存.Text = "新增";
            this.btn儲存.UseVisualStyleBackColor = true;
            this.btn儲存.Click += new System.EventHandler(this.btn儲存_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtp生日);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt地址);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(355, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 468);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "個人基本資料";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Bisque;
            this.lblID.Location = new System.Drawing.Point(92, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(174, 26);
            this.lblID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // dtp生日
            // 
            this.dtp生日.Location = new System.Drawing.Point(90, 396);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(263, 33);
            this.dtp生日.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "生日:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 323);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 33);
            this.txtEmail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // txt地址
            // 
            this.txt地址.Location = new System.Drawing.Point(90, 248);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(263, 33);
            this.txt地址.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "地址:";
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(90, 175);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(213, 33);
            this.txt電話.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "電話:";
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(90, 97);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(213, 33);
            this.txt姓名.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "姓名:";
            // 
            // 會員TableAdapter
            // 
            this.會員TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 專題.mydbDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.會員TableAdapter = this.會員TableAdapter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 帳號DataGridViewTextBoxColumn
            // 
            this.帳號DataGridViewTextBoxColumn.DataPropertyName = "帳號";
            this.帳號DataGridViewTextBoxColumn.HeaderText = "帳號";
            this.帳號DataGridViewTextBoxColumn.Name = "帳號DataGridViewTextBoxColumn";
            // 
            // 密碼DataGridViewTextBoxColumn
            // 
            this.密碼DataGridViewTextBoxColumn.DataPropertyName = "密碼";
            this.密碼DataGridViewTextBoxColumn.HeaderText = "密碼";
            this.密碼DataGridViewTextBoxColumn.Name = "密碼DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // 生日DataGridViewTextBoxColumn
            // 
            this.生日DataGridViewTextBoxColumn.DataPropertyName = "生日";
            this.生日DataGridViewTextBoxColumn.HeaderText = "生日";
            this.生日DataGridViewTextBoxColumn.Name = "生日DataGridViewTextBoxColumn";
            // 
            // chk員工註冊
            // 
            this.chk員工註冊.AutoSize = true;
            this.chk員工註冊.Location = new System.Drawing.Point(105, 180);
            this.chk員工註冊.Name = "chk員工註冊";
            this.chk員工註冊.Size = new System.Drawing.Size(105, 28);
            this.chk員工註冊.TabIndex = 4;
            this.chk員工註冊.Text = "員工註冊";
            this.chk員工註冊.UseVisualStyleBackColor = true;
            // 
            // 註冊帳號
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn儲存);
            this.Name = "註冊帳號";
            this.Text = "註冊帳號";
            this.Load += new System.EventHandler(this.註冊帳號_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.會員BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn儲存;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label6;
        private mydbDataSet2 mydbDataSet2;
        private System.Windows.Forms.BindingSource 會員BindingSource;
        private mydbDataSet2TableAdapters.會員TableAdapter 會員TableAdapter;
        private mydbDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 帳號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生日DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk員工註冊;
    }
}