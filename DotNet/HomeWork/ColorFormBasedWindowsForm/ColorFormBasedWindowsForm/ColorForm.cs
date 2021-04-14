using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorFormBasedWindowsForm
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }
    }
}
