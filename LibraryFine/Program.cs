﻿//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}


using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'libraryFine' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER d1
     *  2. INTEGER m1
     *  3. INTEGER y1
     *  4. INTEGER d2
     *  5. INTEGER m2
     *  6. INTEGER y2
     */

    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        int fine = 0;

        if (d1 > d2 && m1 == m2 && y1 == y2)
        {
            fine = 15 * (d1 - d2);

        }
        else if (m1 > m2 && y1 == y2)
        {
            fine = 500 * (m1 - m2);
        }
        else if (y1 > y2)
            fine = 10000;
        else if (m2 > m1)
            fine = 0;

        return fine;

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int d1, m1, y1, d2, m2, y2;
            //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //    int d1 = Convert.ToInt32(firstMultipleInput[0]);

            //    int m1 = Convert.ToInt32(firstMultipleInput[1]);

            //    int y1 = Convert.ToInt32(firstMultipleInput[2]);

            //    string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //    int d2 = Convert.ToInt32(secondMultipleInput[0]);

            //    int m2 = Convert.ToInt32(secondMultipleInput[1]);

            //    int y2 = Convert.ToInt32(secondMultipleInput[2]);

            int result = Result.libraryFine(9, 6, 2015, 6, 6, 2015);


        }
    }
}