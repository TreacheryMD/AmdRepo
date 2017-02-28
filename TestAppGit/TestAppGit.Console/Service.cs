using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppGit.Console
{
    class Service
    {
        //Test change

        //new line in mybranch
        int n;
        public static int[] revAr(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            return array;
        }

    }
}
