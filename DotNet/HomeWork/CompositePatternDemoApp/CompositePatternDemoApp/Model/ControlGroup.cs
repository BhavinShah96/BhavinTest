using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemoApp.Model
{
    class ControlGroup : IHtml
    {
        private string tag;
        private StringBuilder str = new StringBuilder();
        private List<IHtml> controls = new List<IHtml>();

        public ControlGroup(string tag)
        {
            this.tag = tag;
        }
        public void addElement(IHtml ihtml)
        {
            controls.Add(ihtml);
        }

        public StringBuilder parseHtml()
        {
            str.Append("<" + tag + ">\n");
            if (controls != null)
            {
                foreach (IHtml i in controls)
                {
                    str.Append(i.parseHtml());
                }
            }
            str.Append("</" + tag + ">\n");
            return str;
        }
    }
}
