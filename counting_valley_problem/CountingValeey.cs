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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        char[] chararr = s.ToCharArray();
        int valleyCount = 0;
        int steps = 0;
        for(var i = 0; i < chararr.Length; i++) {
            if(Char.ToLower(chararr[i]) == 'u') {
                steps++;
            }
            else {
                steps--;
            }

            if(steps == 0 && Char.ToLower(chararr[i]) != 'd') {
                valleyCount++;
            }
        }
        return valleyCount;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
