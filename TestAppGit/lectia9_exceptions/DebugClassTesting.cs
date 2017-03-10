using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lectia5
{
    class DebugClassTesting
    {
        public static void Run()
        {
            #region Debug_WriteLine
            Debug.Write("T");
            Debug.Write("E");
            Debug.Write("S");
            Debug.Write("T ");
            Debug.WriteLine("Message is written");
            #endregion

            #region DelimitedListTraceListener
            // Create trace listener.

            var path = Path.GetFullPath(@"debugfile.txt");
            TraceListener listener = new DelimitedListTraceListener(path);

            // Add listener.
            Debug.Listeners.Add(listener);

            // Write and flush.
            Debug.WriteLine("Some text in debugFile will be written");
            Debug.Flush();

            //result is debugfile
            #endregion

            #region Indent_and_Unindent
            Debug.WriteLine("One");
            Debug.IndentLevel = 10;
            Debug.WriteLine("Two");
            Debug.WriteLine("Three");
            Debug.IndentLevel = 0;
            Debug.WriteLine("Four");
            //sau Debug.Indent(); and  Debug.Unindent();
            #endregion

            #region IdentSize
            // Write IndentSize.
            Debug.WriteLine(Debug.IndentSize); //spatii 

            // Change IndentSize.
            Debug.IndentSize = 2;
            Debug.IndentLevel = 1;
            Debug.WriteLine("Testing");
            #endregion

            #region WriteLineIf_and_WriteIf 

            Debug.WriteLineIf(int.Parse("10") == 10, "Ten");
            Debug.WriteIf(true, "True");
            Debug.WriteLine("Done");

            #endregion

            #region Assert 
            //interrupts normal operation of the program but does not terminate the application
            //var value = -1;
            // If value is ever -1, dialog will be shown.
            //Debug.Assert(value != -1, "Value must never be -1.");

            #endregion
        }
    }
}
