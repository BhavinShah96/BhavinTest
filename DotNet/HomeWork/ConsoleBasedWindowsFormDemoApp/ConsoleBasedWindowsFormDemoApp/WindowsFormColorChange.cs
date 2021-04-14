using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleBasedWindowsFormDemoApp
{

    public partial class WindowsFormColorChange : Form
    public Button CalcButton;
    {
        public WindowsFormColorChange()
        {
            InitializeComponent();
            CalcButton = new Button();
            CalcButton.Text = "Calculator";
            CalcButton.Location = new Point(300, 100);
            this.Controls.Add(CalcButton);
            CalcButton.Click += (sender, e) => CalcOperation(50, 20);
        }

        private void WindowsFormColorChange_Load(object sender, EventArgs e)
        {

        }
    }
}
