using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

class Year2015Day5
{
    public static void Ex1()
    {
        string[] lines = File.ReadAllLines("201505.txt");

        string vowels = "aeiou";

        int nice = 0;

        foreach (string line in lines)
        {
            bool threeVowels = false;
            bool pair = false;
            int v = 0;
            char p = '1';
            foreach (char c in line)
            {
                if (vowels.Contains(c)) v++;
                if (c == p) pair = true;
                p = c;
            }

            if (v >= 3) threeVowels = true;

            if (pair && threeVowels)
            {
                if (!(line.Contains("ab") || line.Contains("cd") || line.Contains("pq") || line.Contains("xy")))
                {
                    nice++;
                }
            }
        }

        Console.WriteLine(nice);
    }

    public static void Ex2()
    {
        string[] lines = File.ReadAllLines("201505.txt");

        int nice = 0;

        foreach (string line in lines)
        {
            bool rule1 = false;
            bool rule2 = false;
            char c = '0';

            for (int i = 0; i < line.Length - 1; i++)
            {
                string sub = line.Substring(i, 2);
                if (line.IndexOf(sub, i + 2) != -1)
                {
                    rule1 = true;
                    break;
                }
            }

            for (int i = 0; i < line.Length; i++)
            {
                c = line[i];
                int j = line.IndexOf(c, i + 1);
                if (j == i + 2) 
                {
                    rule2 = true;
                    break;
                }
            }

            if (rule1 && rule2) 
            {
                Console.WriteLine(line);
                nice++;
            }
        }

        Console.WriteLine(nice);
    }
}
