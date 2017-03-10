using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class HandleException
    {

        public void test1()
        {
            try
            {
                StreamReader reader = null;

                try
                {
                    reader = new StreamReader(Path.GetFullPath(@"AccountAmmount.txt"));
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var ammount = Convert.ToDecimal(line);
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Please check if the file {ex.FileName} exist");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Your file does not contain valid number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please try again later...");
                    if (File.Exists(Path.GetFullPath(@"Log.txt")))
                    {
                        StreamWriter sw = new StreamWriter(Path.GetFullPath(@"Log.txt"));
                        sw.Write(ex.GetType().FullName);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                    }
                    else
                    {
                        throw new FileNotFoundException($"{Path.GetFullPath(@"Log.txt")} is not present");
                    }
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Current Exception = { ex.GetType().Name}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"inner Exception = {ex.InnerException.GetType().Name}");
                }

            }
        }

    }
}
