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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double[] arrCount = new double[4];
        
        foreach(int i in arr) {
            if (i > 0) {
                arrCount[0]++;
            } else if (i == 0) {
                arrCount[2]++;
            } else {
                arrCount[1]++;
            }
            arrCount[3]++;
        }

        if (arrCount[3] == 0) {arrCount[3]++;}

        for(int i = 0; i < 3; i++) {
            Console.WriteLine((arrCount[i]/arrCount[3]).ToString("F4"));
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // Console Input Array Size
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        // Console Input Array Numbers separated by Spaces
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        // Process Answer
        Result.plusMinus(arr);
    }
}
