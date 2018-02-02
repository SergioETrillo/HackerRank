using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    private static int alphabetLength = 26;
    
    static string caesarCipher(string s, int k) {
        // Complete this function
        string ciphered="";
        
        foreach (char c in s)
        {
            if (Char.IsUpper(c))
            {
                ciphered += GetCipheredChar('A', c, k);
            } 
            else if (Char.IsLower(c))
            {
                ciphered += GetCipheredChar('a', c, k);
            }
            else
                ciphered += c;
        }
        return ciphered;
    }
    
    static char GetCipheredChar(char init, char c, int k)
    {
        int offset = (c - init + k) % alphabetLength;
        return (char)(init + offset);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        string result = caesarCipher(s, k);
        Console.WriteLine(result);
    }
}