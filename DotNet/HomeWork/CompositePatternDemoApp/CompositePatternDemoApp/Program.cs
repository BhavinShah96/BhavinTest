using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternDemoApp.Model;
using System.IO;

namespace CompositePatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup html = new ControlGroup("html");
            ControlGroup body = new ControlGroup("body");
            ControlGroup div = new ControlGroup("div");
            Control input1 = new Control("input", "text", "First Name");
            Control input2 = new Control("input", "text", "password");
            Control input3 = new Control("input", "button", "login");

            div.addElement(input1);
            div.addElement(input2);
            div.addElement(input3);
            body.addElement(div);
            html.addElement(body);

            string path = @"C:\swabhav\DotNet\HomeWork\Elements.html";
            File.WriteAllText(path, html.parseHtml().ToString());


        }
    }
}
