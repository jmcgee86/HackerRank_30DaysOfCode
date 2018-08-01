using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int swapsCounter = 0;
        for (int i = 0; i < n; i++) 
        {  
            for (int j = 0; j < n - 1; j++) 
            {
                if (a[j] > a[j + 1]) 
                {
                    int temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;
                    swapsCounter++;
                }
            }
            if (swapsCounter == 0) {
                break;
            }
        }
        Console.WriteLine("Array is sorted in {0} swaps.", swapsCounter);
        Console.WriteLine("First Element: " + a.Min());
        Console.WriteLine("Last Element: " + a.Max());
    }
}