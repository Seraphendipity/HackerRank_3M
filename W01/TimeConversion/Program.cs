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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */


    /* 12AM/PM: never realized till now how ambiguous this is.
        We start at 12 and then go 1-11. Most sources cite 12AM/PM
        as ambiguous terms, and noon/midnight should be used.
        Japan's 00:00 seems a bit more logical.
        Military time is best of course.

        For common convention, and this problem, 12PM is noon, making
        the conversion a lot less cutesy and clean.
        12:00:00PM
        01:00:00PM
    */
    public static string timeConversion(string s)
    {

        string sHour = s.Substring(0,2);
        char sM = s[8];

        if(sM == 'P' && sHour != "12" ) {
            s = (Int32.Parse(s.Substring(0,2))+12).ToString("D2") + s.Substring(2,6);
        } else if (sM == 'A' && sHour == "12") {
            s = (Int32.Parse(s.Substring(0,2))-12).ToString("D2") + s.Substring(2,6);
        } else {
            s = s.Substring(0,8);
        }
        return s;
    }

}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


// class Solution
// {
//     public static void Main(string[] args)
//     {

//         string outputPath = "output.txt";
//         System.Environment.SetEnvironmentVariable("OUTPUT_PATH", outputPath);

//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         string? s = Console.ReadLine();
//         string result = Result.timeConversion(s);
//         Console.WriteLine(result);

//        textWriter.WriteLine(result);

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }
