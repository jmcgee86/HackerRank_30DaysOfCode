using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}
public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        var sum = 0;
        var counter = 1;
        while(counter<=n)
        {
            if(n%counter ==0)
            sum+=counter;
            counter++;
        }
        return sum;
    }
}
class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}