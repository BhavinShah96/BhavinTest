using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleteAppDemo.Model
{
    public abstract class Game
    {
        public virtual void start() { }

        public virtual void stop() { }
        public virtual void resume() { }
        public virtual void halfTime() { }

        public void Play()
        {
            start();
            halfTime();
            resume();
            stop();
        }
    }
}
