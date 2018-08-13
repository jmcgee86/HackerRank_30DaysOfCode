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
    static List<string> names = new List<string>();
    
    static void isGmail(string name, string email)
    {
        string check = email;
        string gmail = "@gmail.com";
        if(check.Contains(gmail))
           names.Add(name);
    }               
    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int NItr = 0; NItr < N; NItr++) {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];
            
            isGmail(firstName, emailID);
        }
        names.Sort();
        foreach(var name in names)
            Console.WriteLine(name);
    }
}