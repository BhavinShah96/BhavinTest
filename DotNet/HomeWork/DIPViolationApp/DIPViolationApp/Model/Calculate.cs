using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.Model
{
    class Calculate
    {
        LogType log;

        public Calculate(LogType log)
        {
            this.log = log;
        }

        public int CalculateTax(int amount, int rate)
        {
            try
            {
                int result = amount / rate;
                return result;
            }
            catch (Exception e)
            {
                if (log.Equals(LogType.JSON))
                {
                    new JSONLogger().log("Dont devide by 0");
                }
                else if (log.Equals(LogType.TXT))
                {
                    new TXTLogger().log("Dont devide by 0");
                }
                else if (log.Equals(LogType.XML))
                {
                    new XMLLogger().log("Dont devide by 0");
                }
                return -1;

            }
        }
    }
}
