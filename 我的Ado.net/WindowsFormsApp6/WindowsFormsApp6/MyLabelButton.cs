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
    class MyLabelButton : Label
    {
        public Button myDButton;

        public MyLabelButton()
        {
            myDButton = new Button();
            myDButton.BackColor = Color.LightYellow;
            myDButton.ForeColor = Color.Purple;
            myDButton.Font = new Font("微軟正黑體", 14);
            myDButton.Name = "btnDbutton";
            myDButton.Size = new Size(150, 40);
            myDButton.Location = new Point(110, 5);
            myDButton.Text = "Label內按鈕";
            Controls.Add(myDButton);
        }
    }
}
