using System;
using System.Collections.Generic;
using System.IO;

class Year2015Day1
{
    public static void Ex1(string[] args)
    {
        string s = File.ReadAllText("201501.txt");
        int floor = 0;

        foreach (char c in s)
        {
            if (c == '(') floor++;
            else floor--;
        }

        Console.WriteLine(floor);
    }

    public static void Ex2()
    {
        string s = File.ReadAllText("201501.txt");
        int floor = 0;
        int i = 1;

        foreach (char c in s)
        {
            if (c == '(') floor++;
            else floor--;

            if (floor == -1)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}
