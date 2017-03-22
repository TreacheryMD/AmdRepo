using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 40;

            #region Encoding and Decoding
            // writing
            using (StreamWriter writer = new StreamWriter(new FileStream("Encoding.txt", FileMode.OpenOrCreate),Encoding.UTF8))
            {
                writer.WriteLine("This is in UTF8");
            }
            //or
            // reading
            //fs = new FileStream("Encoding.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(new FileStream("Encoding.txt", FileMode.OpenOrCreate), Encoding.UTF8))
            {
                string str = reader.ReadLine();
            }
            #endregion

            #region String Encoding 

            #region withWebRequest
            //try
            //{
            //    var theRequest = WebRequest.Create(@"http://www.mindcracker.com");
            //    var theResponse = theRequest.GetResponse();
            //    var buffer = new Byte[256]; // Buffer Size
            //    Stream responseStream = theResponse.GetResponseStream();
            //    if (responseStream != null)
            //    {
            //        var bytesRead = responseStream.Read(buffer, 0, 256);
            //        StringBuilder strResponse = new StringBuilder(@"");

            //        while (bytesRead != 0)
            //        {
            //            // Returns an encoding for the ASCII (7 bit) character set
            //            // ASCII characters are limited to the lowest 128 Unicode
            //            // characters
            //            // , from U+0000 to U+007f.
            //            strResponse.Append(Encoding.ASCII.GetString(buffer,
            //                0, bytesRead));
            //            bytesRead = responseStream.Read(buffer, 0, 256);
            //        }

            //        Console.Write(strResponse.ToString());
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.Write("Exception Occured!{0}", e);
            //}

            //Console.WriteLine(new string('*', r));

            #endregion


            #region Encoding

            //Encode
            string plainText = "Some String";
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            string base64EncodedData = Convert.ToBase64String(plainTextBytes);

            //Decode

            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            string baseUTF8 = Encoding.UTF8.GetString(base64EncodedBytes);

            Console.WriteLine(plainText);
            foreach (var item in plainTextBytes)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(base64EncodedData);

            foreach (var item in base64EncodedBytes)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(baseUTF8);

            Console.WriteLine(new string('*', r));
            #endregion

            #endregion

            #region String Formating examples

            #region First Example
            string value1 = "Trying to have some fun";
            int value2 = 5000;
            double ratio = 0.74;
            DateTime value3 = DateTime.Now;
            
            string result = $"{value1}: {value2:0.0000} - {value3:yyyy.+.-.MMM.+.-*...dd} Ratio: {ratio:P}";
            Console.WriteLine(result);

            Console.WriteLine(new string('*', r));
            #endregion

            #region Second Example
            // A negative number means to left-align.
            // A positive number means to right-align.
            const string format = "{0,-10} {1,10}";
            string line1 = string.Format(format,4000,5000);
            string line2 = string.Format(format,"Dogs","Cats");
            Console.WriteLine(line1);
            Console.WriteLine(line2);

            Console.WriteLine(new string('*', r));
            #endregion

            #region Third Example
            int value4 = 10995;

            // Write number in hex format.
            Console.WriteLine("{0:x}", value4);
            Console.WriteLine("{0:x8}", value4);

            Console.WriteLine("{0:X}", value4);
            Console.WriteLine("{0:X8}", value4);
            
            // Convert to hex.
            string hex = value4.ToString("X8");

            // Convert from hex to integer.
            int newNum = int.Parse(hex, NumberStyles.AllowHexSpecifier);
             Console.WriteLine(value4 == newNum);
            Console.WriteLine(new string('*', r));
            #endregion

            #endregion

            #region String Searching

            var bigStr = "First of all, this is just a test, so no big deal what will happen to this string";

            Console.WriteLine(bigStr.Contains("this"));
            Console.WriteLine(bigStr.StartsWith("First"));
            Console.WriteLine(bigStr.EndsWith("string"));
            Console.WriteLine(new string('*', r));


            #endregion

            #region String Comparing

            var str1 = "One two three";
            var str2 = "One Two Three";
            var str3 = str2.ToLower();

            Console.WriteLine(string.Equals(str1, str2));
            Console.WriteLine(string.Equals(str1, str3, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(new string('*', r));
            #endregion

            #region String Order Comparison

            Console.WriteLine(string.Compare("first string",0,"second string",0,1,true,CultureInfo.CurrentUICulture));
            Console.WriteLine(string.Compare("first string", 0, "second string", 1, 1, true, CultureInfo.CurrentUICulture));
            Console.WriteLine(string.Compare("first string", 3, "Second string", 0, 1, true, CultureInfo.CurrentUICulture));
            Console.WriteLine(string.Compare("first string", 3, "Second string", 0, 1, false, CultureInfo.CurrentUICulture));

            Console.WriteLine(new string('*', r));
            #endregion

            #region DateAndTime - TimeSpan

            TimeSpan ts = new TimeSpan(1,2,32,50);
            Console.WriteLine(ts.TotalMilliseconds);
            Console.WriteLine(ts.Ticks);

            Console.WriteLine(new string('*', r));
            #endregion

            #region DateTime

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddDays(40));
            Console.WriteLine(DateTime.Now.Subtract(ts));

            DateTimeOffset dt = new DateTimeOffset(DateTime.Now);
            Console.WriteLine(dt);

            DateTime dateTimeToday = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Utc);
            DateTime dateTimeTodayLocal = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Local);

            Console.WriteLine(dateTimeToday);
            Console.WriteLine(dt= dateTimeToday);
            Console.WriteLine(dt = dateTimeTodayLocal);

            TimeZone tz = TimeZone.CurrentTimeZone;
            Console.WriteLine(tz.StandardName);
            Console.WriteLine(tz.DaylightName);
            Console.WriteLine(tz.IsDaylightSavingTime(dateTimeToday));
            Console.WriteLine(tz.GetUtcOffset(DateTime.Now));

            Console.WriteLine(new string('*', r));
            #endregion

            #region FormatProviders


            NumberFormatInfo current1 = CultureInfo.CurrentCulture.NumberFormat;
            Console.WriteLine(current1.CurrencyDecimalDigits);
            Console.WriteLine(current1.CurrencyGroupSeparator);

            NumberFormatInfo current3 = NumberFormatInfo.GetInstance(CultureInfo.CurrentCulture);
            Console.WriteLine(current3.IsReadOnly);

            NumberFormatInfo newF = new NumberFormatInfo {NumberGroupSeparator = "+"};

            Console.WriteLine(5465454.454.ToString("N1", current1));
            Console.WriteLine(5465454.454.ToString("N3", newF));

            var culture = CultureInfo.CurrentCulture;
            Console.WriteLine("Culture Name:    {0}", culture.Name);
            Console.WriteLine("User Overrides:  {0}", culture.UseUserOverride);
            Console.WriteLine("Currency Symbol: {0}", culture.NumberFormat.CurrencySymbol);

            culture = new CultureInfo(CultureInfo.CurrentCulture.Name, false);
            Console.WriteLine("Culture Name:    {0}", culture.Name);
            Console.WriteLine("User Overrides:  {0}", culture.UseUserOverride);
            Console.WriteLine("Currency Symbol: {0}", culture.NumberFormat.CurrencySymbol);

            Console.WriteLine(3.ToString("C",culture));

            var dtfi = DateTimeFormatInfo.InvariantInfo;
            Console.WriteLine(dtfi.IsReadOnly);
            Console.WriteLine(dtfi.FullDateTimePattern);
            Console.WriteLine(dtfi.ShortDatePattern);
            Console.WriteLine(dtfi.FirstDayOfWeek);

            Console.WriteLine(new string('*', r));

            // Instantiate a culture using CreateSpecificCulture.
            var ci = CultureInfo.CreateSpecificCulture("en-US");
            dtfi = ci.DateTimeFormat;
            Console.WriteLine("{0} from CreateSpecificCulture: {1}", ci.Name, dtfi.IsReadOnly);


            #endregion

            #region Don’t do it unless you need to

            MyResources res = new MyResources(@"NewFile.txt");

            try
            {
                res.ShowData();
            }
            finally
            {
                res.Dispose();
            }

           
            #endregion


            Console.ReadLine();
        }
           
        
    }
}
