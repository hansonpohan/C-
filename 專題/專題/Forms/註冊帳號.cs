using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專題.Forms
{
    public partial class 註冊帳號 : Form
    {
        public 註冊帳號()
        {
            InitializeComponent();
        }

        private void 會員BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.會員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet2);

        }

        private void 註冊帳號_Load(object sender, EventArgs e)
        {

        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            會員BindingSource.AddNew();
            dtp生日.Value = new DateTime(1900, 1, 1, 0, 0, 0);
        }

        private void btn儲存_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要儲存?", "儲存確認", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            { //yes 儲存
                //未來工作時, 要做欄位檢查
                Validate();
                會員BindingSource.EndEdit();
                會員TableAdapter.Update(mydbDataSet2.會員);
               
                MessageBox.Show("資料儲存成功");

            }
            else
            { // no

            }
        }
    }
}
