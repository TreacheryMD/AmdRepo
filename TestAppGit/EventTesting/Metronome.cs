using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTesting
{
    public class Metronome
    {
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(Metronome m, EventArgs e);
        public void Start()
        {
            while (true) //forever
            {
                System.Threading.Thread.Sleep(3000);
                Tick?.Invoke(this, e);
            }
        }
    }
    
    
}
