using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class MyUserControlOne : UserControl
    {
        public MyUserControlOne()
        {
            InitializeComponent();
        }

        private void MyUserControlOne_Load(object sender, EventArgs e)
        {

        }

        private void btn更改標題_Click(object sender, EventArgs e)
        {
            lbl標籤標題.Text = txt輸入文字.Text;
        }
    }
}
