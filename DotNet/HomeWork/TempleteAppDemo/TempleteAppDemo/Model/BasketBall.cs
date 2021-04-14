using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleteAppDemo.Model
{
    class BasketBall : Game
    {
        public override void start()
        {
            Console.WriteLine("Basket Ball Game started.");
        }
        public override void stop()
        {
            Console.WriteLine("Basket Ball Game stopped.");
        }
        public override void halfTime()
        {
            Console.WriteLine("Basket Ball HalfTime.");
        }
        public override void resume()
        {
            Console.WriteLine("Basket Ball game is Resumed now.");
        }
    }
}
