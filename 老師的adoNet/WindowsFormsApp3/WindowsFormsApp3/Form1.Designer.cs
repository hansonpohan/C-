
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mydbDataSet = new WindowsFormsApp3.mydbDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new WindowsFormsApp3.mydbDataSetTableAdapters.personsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.mydbDataSetTableAdapters.TableAdapterManager();
            this.personsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.personsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt點數 = new System.Windows.Forms.TextBox();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.btn第一筆 = new System.Windows.Forms.Button();
            this.btn上一筆 = new System.Windows.Forms.Button();
            this.btn下一筆 = new System.Windows.Forms.Button();
            this.btn最後一筆 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn回復資料 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn新增資料_新增 = new System.Windows.Forms.Button();
            this.btn新增資料_儲存 = new System.Windows.Forms.Button();
            this.lbl第幾筆共幾筆 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).BeginInit();
            this.personsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            this.personsBindingSource.DataSource = this.mydbDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personsBindingNavigator
            // 
            this.personsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personsBindingNavigator.BindingSource = this.personsBindingSource;
            this.personsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.personsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personsBindingNavigatorSaveItem});
            this.personsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personsBindingNavigator.Name = "personsBindingNavigator";
            this.personsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personsBindingNavigator.Size = new System.Drawing.Size(1288, 33);
            this.personsBindingNavigator.TabIndex = 0;
            this.personsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(110, 28);
            this.bindingNavigatorAddNewItem.Text = "新增資料";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(110, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除資料";
            // 
            // personsBindingNavigatorSaveItem
            // 
            this.personsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personsBindingNavigatorSaveItem.Image")));
            this.personsBindingNavigatorSaveItem.Name = "personsBindingNavigatorSaveItem";
            this.personsBindingNavigatorSaveItem.Size = new System.Drawing.Size(110, 28);
            this.personsBindingNavigatorSaveItem.Text = "儲存資料";
            this.personsBindingNavigatorSaveItem.Click += new System.EventHandler(this.personsBindingNavigatorSaveItem_Click);
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AutoGenerateColumns = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.personsDataGridView.DataSource = this.personsBindingSource;
            this.personsDataGridView.Location = new System.Drawing.Point(1211, 36);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.RowHeadersWidth = 62;
            this.personsDataGridView.RowTemplate.Height = 31;
            this.personsDataGridView.Size = new System.Drawing.Size(77, 111);
            this.personsDataGridView.TabIndex = 1;
            this.personsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "姓名";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "電話";
            this.dataGridViewTextBoxColumn3.HeaderText = "電話";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "地址";
            this.dataGridViewTextBoxColumn4.HeaderText = "地址";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "生日";
            this.dataGridViewTextBoxColumn6.HeaderText = "生日";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.HeaderText = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "點數";
            this.dataGridViewTextBoxColumn7.HeaderText = "點數";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "生日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 35);
            this.label7.TabIndex = 8;
            this.label7.Text = "婚姻狀態";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(13, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "點數";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Id", true));
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(123, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(186, 35);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt姓名
            // 
            this.txt姓名.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "姓名", true));
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(116, 89);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(356, 45);
            this.txt姓名.TabIndex = 11;
            // 
            // txt電話
            // 
            this.txt電話.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "電話", true));
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(116, 140);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(356, 45);
            this.txt電話.TabIndex = 12;
            // 
            // txt地址
            // 
            this.txt地址.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "地址", true));
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(116, 191);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(496, 45);
            this.txt地址.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "email", true));
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(116, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(496, 45);
            this.txtEmail.TabIndex = 14;
            // 
            // txt點數
            // 
            this.txt點數.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "點數", true));
            this.txt點數.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt點數.Location = new System.Drawing.Point(116, 394);
            this.txt點數.Name = "txt點數";
            this.txt點數.Size = new System.Drawing.Size(193, 45);
            this.txt點數.TabIndex = 15;
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personsBindingSource, "婚姻狀態", true));
            this.chk婚姻狀態.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk婚姻狀態.Location = new System.Drawing.Point(189, 344);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(97, 39);
            this.chk婚姻狀態.TabIndex = 16;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // dtp生日
            // 
            this.dtp生日.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "生日", true));
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(116, 297);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(356, 45);
            this.dtp生日.TabIndex = 17;
            // 
            // btn第一筆
            // 
            this.btn第一筆.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn第一筆.Location = new System.Drawing.Point(45, 464);
            this.btn第一筆.Name = "btn第一筆";
            this.btn第一筆.Size = new System.Drawing.Size(196, 48);
            this.btn第一筆.TabIndex = 18;
            this.btn第一筆.Text = "第一筆";
            this.btn第一筆.UseVisualStyleBackColor = true;
            this.btn第一筆.Click += new System.EventHandler(this.btn第一筆_Click);
            // 
            // btn上一筆
            // 
            this.btn上一筆.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上一筆.Location = new System.Drawing.Point(247, 464);
            this.btn上一筆.Name = "btn上一筆";
            this.btn上一筆.Size = new System.Drawing.Size(196, 48);
            this.btn上一筆.TabIndex = 19;
            this.btn上一筆.Text = "上一筆";
            this.btn上一筆.UseVisualStyleBackColor = true;
            this.btn上一筆.Click += new System.EventHandler(this.btn上一筆_Click);
            // 
            // btn下一筆
            // 
            this.btn下一筆.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下一筆.Location = new System.Drawing.Point(449, 464);
            this.btn下一筆.Name = "btn下一筆";
            this.btn下一筆.Size = new System.Drawing.Size(196, 48);
            this.btn下一筆.TabIndex = 20;
            this.btn下一筆.Text = "下一筆";
            this.btn下一筆.UseVisualStyleBackColor = true;
            this.btn下一筆.Click += new System.EventHandler(this.btn下一筆_Click);
            // 
            // btn最後一筆
            // 
            this.btn最後一筆.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn最後一筆.Location = new System.Drawing.Point(651, 464);
            this.btn最後一筆.Name = "btn最後一筆";
            this.btn最後一筆.Size = new System.Drawing.Size(196, 48);
            this.btn最後一筆.TabIndex = 21;
            this.btn最後一筆.Text = "最後一筆";
            this.btn最後一筆.UseVisualStyleBackColor = true;
            this.btn最後一筆.Click += new System.EventHandler(this.btn最後一筆_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.Location = new System.Drawing.Point(45, 518);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(196, 48);
            this.btn儲存修改.TabIndex = 22;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(247, 518);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(196, 48);
            this.btn刪除.TabIndex = 23;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn回復資料
            // 
            this.btn回復資料.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回復資料.Location = new System.Drawing.Point(449, 518);
            this.btn回復資料.Name = "btn回復資料";
            this.btn回復資料.Size = new System.Drawing.Size(196, 48);
            this.btn回復資料.TabIndex = 24;
            this.btn回復資料.Text = "回復資料";
            this.btn回復資料.UseVisualStyleBackColor = true;
            this.btn回復資料.Click += new System.EventHandler(this.btn回復資料_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btn新增資料_儲存);
            this.groupBox1.Controls.Add(this.btn新增資料_新增);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(652, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增資料";
            // 
            // btn新增資料_新增
            // 
            this.btn新增資料_新增.Location = new System.Drawing.Point(32, 38);
            this.btn新增資料_新增.Name = "btn新增資料_新增";
            this.btn新增資料_新增.Size = new System.Drawing.Size(137, 43);
            this.btn新增資料_新增.TabIndex = 0;
            this.btn新增資料_新增.Text = "新增";
            this.btn新增資料_新增.UseVisualStyleBackColor = true;
            this.btn新增資料_新增.Click += new System.EventHandler(this.btn新增資料_新增_Click);
            // 
            // btn新增資料_儲存
            // 
            this.btn新增資料_儲存.Location = new System.Drawing.Point(187, 38);
            this.btn新增資料_儲存.Name = "btn新增資料_儲存";
            this.btn新增資料_儲存.Size = new System.Drawing.Size(137, 43);
            this.btn新增資料_儲存.TabIndex = 1;
            this.btn新增資料_儲存.Text = "儲存";
            this.btn新增資料_儲存.UseVisualStyleBackColor = true;
            this.btn新增資料_儲存.Click += new System.EventHandler(this.btn新增資料_儲存_Click);
            // 
            // lbl第幾筆共幾筆
            // 
            this.lbl第幾筆共幾筆.AutoSize = true;
            this.lbl第幾筆共幾筆.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl第幾筆共幾筆.Location = new System.Drawing.Point(373, 421);
            this.lbl第幾筆共幾筆.Name = "lbl第幾筆共幾筆";
            this.lbl第幾筆共幾筆.Size = new System.Drawing.Size(149, 30);
            this.lbl第幾筆共幾筆.TabIndex = 26;
            this.lbl第幾筆共幾筆.Text = "第X筆/共X筆";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1288, 646);
            this.Controls.Add(this.lbl第幾筆共幾筆);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn回復資料);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.btn最後一筆);
            this.Controls.Add(this.btn下一筆);
            this.Controls.Add(this.btn上一筆);
            this.Controls.Add(this.btn第一筆);
            this.Controls.Add(this.dtp生日);
            this.Controls.Add(this.chk婚姻狀態);
            this.Controls.Add(this.txt點數);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personsDataGridView);
            this.Controls.Add(this.personsBindingNavigator);
            this.Name = "Form1";
            this.Text = "會員資料表單(SQL Server)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).EndInit();
            this.personsBindingNavigator.ResumeLayout(false);
            this.personsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private mydbDataSetTableAdapters.personsTableAdapter personsTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt點數;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Button btn第一筆;
        private System.Windows.Forms.Button btn上一筆;
        private System.Windows.Forms.Button btn下一筆;
        private System.Windows.Forms.Button btn最後一筆;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn回復資料;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn新增資料_儲存;
        private System.Windows.Forms.Button btn新增資料_新增;
        private System.Windows.Forms.Label lbl第幾筆共幾筆;
    }
}

