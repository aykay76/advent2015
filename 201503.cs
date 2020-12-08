using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Year2015Day3
{
    public static void Ex1()
    {
        string s = File.ReadAllText("201503.txt");

        int x = 0;
        int y = 0;

        List<KeyValuePair<int, int>> houses = new List<KeyValuePair<int, int>>();

        houses.Add(new KeyValuePair<int, int>(x, y));

        foreach (char c in s)
        {
            if (c == '<') x--;
            if (c == '>') x++;
            if (c == '^') y++;
            if (c == 'v') y--;

            KeyValuePair<int, int> item = new KeyValuePair<int, int>(x, y);
            if (houses.Contains(item) == false)
            {
                houses.Add(item);
            }
        }

        Console.WriteLine(houses.Count);
    }

    public static void Ex2()
    {
        string s = File.ReadAllText("201503.txt");

        int sx = 0;
        int sy = 0;
        int rx = 0;
        int ry = 0;

        List<KeyValuePair<int, int>> houses = new List<KeyValuePair<int, int>>();

        houses.Add(new KeyValuePair<int, int>(sx, sy));

        bool robo = false;
        foreach (char c in s)
        {
            if (robo)
            {
                if (c == '<') rx--;
                if (c == '>') rx++;
                if (c == '^') ry++;
                if (c == 'v') ry--;
                KeyValuePair<int, int> item = new KeyValuePair<int, int>(rx, ry);
                if (houses.Contains(item) == false)
                {
                    houses.Add(item);
                }
            }
            else
            {
                if (c == '<') sx--;
                if (c == '>') sx++;
                if (c == '^') sy++;
                if (c == 'v') sy--;
                KeyValuePair<int, int> item = new KeyValuePair<int, int>(sx, sy);
                if (houses.Contains(item) == false)
                {
                    houses.Add(item);
                }
            }

            robo = !robo;
        }

        Console.WriteLine(houses.Count);
    }
}
