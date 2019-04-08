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

class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        long result;
        char character = 'a';
        if(n < s.Length) {
            result = CalculateNumberOfCharacters(s.Substring(0, (int)n), character);
        }            
        else {
            result = CalculateNumberOfCharacters(s, character);
            long repeat = n / s.Length;

            result = (result * repeat);
            long leftOut = n % s.Length;
            if(leftOut > 0)
                result = result + CalculateNumberOfCharacters(s.Substring(0, (int)leftOut), character);


        }

        return result;

    }

    static long CalculateNumberOfCharacters(string s, char character) {
            char[] charrArray = s.ToCharArray();
            long count = 0;
            for(var a = 0; a < charrArray.Length; a++) {
                if(charrArray[a] == character) {
                    count++;
                }
            }
        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
