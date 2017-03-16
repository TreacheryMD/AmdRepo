using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTesting
{
    public class Listener
    {
        public void Subscribe(Metronome m)
        {
            m.Tick += HeardIt;
        }
        private void HeardIt(Metronome m, EventArgs e)
        {
            Console.WriteLine("HEARD IT");
        }
    }
}
