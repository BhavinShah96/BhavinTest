using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleBasedWindowsApp
{
    public partial class WelCome : Form
    {
        public delegate void DCalcOperationAlert(int x, int y, int Answer);
        public Button helloButton;
        public Button CalcButton;

        public WelCome()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
            this.Text = "Welcome Window";
            helloButton = new Button();
            helloButton.Text = "Hello";
            helloButton.Location = new Point(100, 100);
            this.Controls.Add(helloButton);
            helloButton.Click += (sender, e) => MessageBox.Show("You clicked Hello....!");


            CalcButton = new Button();
            CalcButton.Text = "Calculator";
            CalcButton.Location = new Point(300, 100);
            this.Controls.Add(CalcButton);
            CalcButton.Click += (sender, e) => CalcOperation(50, 20);
        }
        public void CalcOperation(int x, int y)
        {

            Console.WriteLine("Addition of {0} and {1} is : ", x, y);
            Console.WriteLine("Addition Result : " + (x + y));

            Console.WriteLine("SubStraction of {0} and {1} is : ", x, y);
            Console.WriteLine("Substraction Result : " + (x - y));
        }



        public void WelCome_Load(object sender, EventArgs e)
        {

        }


    }
}
