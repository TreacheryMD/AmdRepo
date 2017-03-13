using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Problema2_3 : Problem
    {
       //Delete all lines, containing only even number elements

        public int[,] TwoDimArr { get; set; }

        public Problema2_3(int[,] twoDimArr)
        {
            TwoDimArr = twoDimArr;
        }
        public void Solve()
        {
            List<int> tempList = new List<int>();
            List<int> rowNr = new List<int>(); 
            int rowLength = TwoDimArr.GetLength(0);
            int colLength = TwoDimArr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < colLength; j++) //all line
                {
                    
                    if (TwoDimArr[i, j] % 2 != 0)
                    { 
                        break;
                    }
                    else
                    {
                        evenCount++;
                    }
                }

                if (evenCount == colLength)
                {
                    tempList.Add(i);
                }
            }

                Console.WriteLine("*****Problema2.3*****");
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (tempList.Contains(i)){break;}
                        Console.Write($"{TwoDimArr[i, j]} ");
                    }
                    if (!tempList.Contains(i))
                    {
                        Console.Write(Environment.NewLine + Environment.NewLine);
                    }
                   
                }
                Console.WriteLine("\n*********************");
                Console.ReadLine();
            }
        }
    }
