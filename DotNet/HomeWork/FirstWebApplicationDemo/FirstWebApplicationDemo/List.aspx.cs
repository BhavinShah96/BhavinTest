using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplicationDemo
{
    public partial class List : System.Web.UI.Page
    {
        List<string> student = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            student.Add("Bhavin");
            student.Add("Inder");

            if (IsPostBack)
            {
                return;
            }
            foreach (var i in student)
            {
                ListBox1.Items.Add(i);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(student.Contains(TextBox1.Text))
            {
                return;
            }
            else
            {
                student.Add(TextBox1.Text);
                ListBox1.Items.Add(TextBox1.Text);
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           


            ListBox1.Items.Remove(ListBox1.SelectedValue);
        }

    }
}