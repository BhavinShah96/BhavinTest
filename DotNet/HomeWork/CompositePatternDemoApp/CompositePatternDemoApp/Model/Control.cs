using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemoApp.Model
{
    class Control : IHtml
    {
        private  string tag;
        private string type;
        private string value;
        
        public Control(string tag, string type, string value)
        {
            this.tag = tag;
            this.type = type;
            this.value = value;
        }
        public Control(string tag)
        {
            this.tag = tag;
        }
        StringBuilder sb = new StringBuilder();
        public StringBuilder parseHtml()
        {
            if(type != null)
            {
                sb.Append("<" + tag + " type : " + type + " value : " + value + ">" + "</" + tag + ">\n");
                return sb;
            }
            sb.Append("<" + tag + ">" + "</" + tag + ">\n");
            return sb;
        }
    }
}
