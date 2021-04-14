using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternDemoApp.Model;

namespace FactoryPatternDemoApp.Model
{
    public class AutoMobileFactory
    {
       public IAutoMobile Make(AutoType type)
        {
            if(type == AutoType.BMW)
            {
                return new BMW();
            }
            if(type == AutoType.AUDI)
            {
                return new Audi();
            }
            return new Tesla();
        }
    }
}
