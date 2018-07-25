using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    //Write your code here
    List<char> charStack = new List<char>();
    List<char> charQueue = new List<char>();

    public void pushCharacter(char ch)
    {
    charStack.Insert(0,ch); 
    }
    
    public void enqueueCharacter(char ch)
    {
        charQueue.Add(ch);
    }
    
    public char popCharacter() 
    {
        var topStack = charStack[0];
        charStack.RemoveAt(0);
        return topStack;
    }
    public char dequeueCharacter() 
    {
        var topQueue = charQueue[0];
        charQueue.RemoveAt(0);
        return topQueue;
    }
    
}
    
    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}