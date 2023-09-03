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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> count = new List<int>{0,0};
        List<int> index = new List<int>{0,0};

        for(int i = 0; i < scores.Count(); ++i) {
            if(scores[i] > scores[index[0]]) {index[0]=i;count[0]++;}
            if(scores[i] < scores[index[1]]) {index[1]=i;count[1]++;}
        }

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        bool debug = false;

        int n = Convert.ToInt32(Console.ReadLine().Trim()); //Unused
        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();
        List<int> result = Result.breakingRecords(scores);
        
        if(debug == true) {Console.WriteLine(String.Join(" ", result));} else {
            // HackerRank Stuff
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            textWriter.WriteLine(String.Join(" ", result));
            textWriter.Flush();
            textWriter.Close();
        }

    }
}
