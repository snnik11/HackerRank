using Microsoft.VisualBasic;
using System;

namespace UtopianTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UtopianTree(5);
        }
        public static int UtopianTree(int n)
        {
            int height = 1;

            for(int a = 0;a <n; a++)
            {
                if(a % 2 ==0)
                {
                    height *= 2;
                    Console.Write("this is % by 2 ");
                    Console.WriteLine(height);
                }
                else
                {
                    height++;
                    Console.Write("this is not ");
                        Console.WriteLine(height);
                }
            }
            Console.WriteLine(height);
            return height;

        }



    }


}