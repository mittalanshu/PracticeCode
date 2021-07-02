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
     * Complete the 'funnyString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string funnyString(string s)
    {
        List<int> llst=new List<int>();
        int flag=0;
        List<int> diff=new List<int>();
        char[] arr=s.ToCharArray();
        foreach(char c in arr){
            for(int i='a';i<='z';i++){
                if(c.Equals((char)i)){
                    llst.Add(i);
                }   
            }
        }
        
       List<int> flst=new List<int>(llst);
        llst.Reverse();
        for(int i=0;i<flst.Count-1;i++){
            if(Math.Abs(flst[i]-flst[i+1])==Math.Abs(llst[i]-llst[i+1]))
                flag=1;
            else {
                flag=0;
                break;
            }
        }
        if(flag==0) return "Not Funny";
        else return "Funny";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
