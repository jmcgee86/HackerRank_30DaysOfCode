using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
// Add your code here

    public Difference(int[] a)
    {
        this.elements = a;
    }
    
    public void computeDifference(){
        Array.Sort(elements);
        maximumDifference = Math.Abs(elements[0]-elements[elements.Length-1]);
    }
}
class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}