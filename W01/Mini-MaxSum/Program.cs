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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    // Note: the >= is a cute solution to inputs having duplicate numbers.
    public static void miniMaxSum(List<int> arr)
    {

        int maxIndex = 0;
        int minIndex = 0;
        long sum = 0;

        // Find Min and Max
        for (int i = 1; i < 5; i++) {
            if (arr[i] >= arr[maxIndex]) {
                maxIndex = i;
            }
            if (arr[i] < arr[minIndex]) {
                minIndex = i;
            }
        }

        // Sum Other Components
        for (int i = 0; i < 5; i++) {
            if(i != minIndex && i != maxIndex) {
                sum += arr[i];
            }
        }

        Console.WriteLine("{0} {1}", sum+arr[minIndex],sum+arr[maxIndex]);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
