using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class MyResources : IDisposable
    {
        //managed resource handle
        private readonly TextReader _tr = null;

        public MyResources(string path)
        {
            //emulate the managed resource aquisition
            Console.WriteLine("Aquiring Managed Resources");
            _tr = new StreamReader(path);

            //emulate the unmanaged resource aquisition
            Console.WriteLine("Aquiring Unmanaged Resources");

        }
        void ReleaseManagedResources()
        {
            Console.WriteLine("Releasing Managed Resources");
            _tr?.Dispose();
        }

        void ReleaseUnmangedResources()
        {
            Console.WriteLine("Releasing Unmanaged Resources");
        }

        public void ShowData()
        {
            //Emulate class usage
            if (_tr != null)
            {
                Console.WriteLine(_tr.ReadToEnd() + " /some unmanaged data ");
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose called from outside");
            Dispose(true);

            //  cleaned so Finalise have nothing to do
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Actual Dispose called with a " + disposing);
            if (disposing)
            {
                //someone want the deterministic release of all resources
                //Let us release all the managed resources
                ReleaseManagedResources();
            }
            else
            {
                // Do nothing, no one asked a dispose, the object went out of  scope and finalized is called so lets next round of GC release these resources
            }

            // Release the unmanaged resource in any case as they will not be  released by GC
            ReleaseUnmangedResources();

        }
        ~MyResources()
        {
            Console.WriteLine("Finalizer called");
            // The object went out of scope and finalized is called
            // call dispose in to release unmanaged resources 
            // the managed resources will anyways be released when GC runs the next time.
            Dispose(false);
        }
    }
}
