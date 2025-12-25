/* 
Function Description
Complete the  function with the following parameter(s):
: an array of  integers
Print
Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.No value should be returned.
Note For some languages, like C, C++, and Java, the sums may require that you use a long integer due to their size.
Input Format
A single line of five space-separated integers.
Constraints

Sample Input
1 2 3 4 5
Sample Output
10 14
Explanation
The numbers are , , , , and . Calculate the following sums using four of the five integers:
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Hints: Beware of integer overflow! Use a 64-bit integer to store the sums.
Need help to get started? Try the Solve Me First problem.

*/

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

    public static void miniMaxSum(List<int> arr)
    {
        int min = int.MaxValue; //max and min values in .net
        int max = int.MinValue;
        long sum = 0;

        
        foreach (var i in arr ) {
            sum += i;
            if (i < min) //with this way we found everything with one loop
                min = i;
            if (i > max)
                max = i;
            } 
        long summax = sum - min;
        long summin = sum - max;
        Console.WriteLine($"{summin} {summax}");
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
