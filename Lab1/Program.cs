using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        private static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("type 2 digit number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("type 2 digit number");
            int num2 = int.Parse(Console.ReadLine());
            {
                List<int> listNum1 = new List<int>();
                while (num1 > 0)
                {
                    listNum1.Add(num1 % 10);
                    num1 = num1 / 10;
                }
                {
                    List<int> listNum2 = new List<int>();
                    while (num2 > 0)
                    {
                        listNum2.Add(num2 % 10);
                        num2 = num2 / 10;
                    }
                    
                        int[] newArray = new int[listNum1.Count];
                        for (int i = 0; i < listNum1.Count; i++)
                        {

                            newArray[i] = listNum1[i] + listNum2[i];

                        }
                    
                }
            }
        }
    }
}


