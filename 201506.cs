using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

class Year2015Day6
{
    public static void Ex1()
    {
        string[] lines = File.ReadAllLines("201506.txt");
        bool[,] lights = new bool[1000,1000];

        foreach (string line in lines)
        {
            bool on = false;
            bool off = false;
            bool toggle = false;
            int sx, sy, ex, ey;
            if (line.StartsWith("turn on "))
            {
                string[] parts = line.Substring(8).Split(" through ");
                string[] start = parts[0].Split(',');
                string[] end = parts[1].Split(',');
                sx = int.Parse(start[0]);
                sy = int.Parse(start[1]);
                ex = int.Parse(end[0]);
                ey = int.Parse(end[1]);
                on = true;
            }
            else if (line.StartsWith("turn off "))
            {
                string[] parts = line.Substring(9).Split(" through ");
                string[] start = parts[0].Split(',');
                string[] end = parts[1].Split(',');
                sx = int.Parse(start[0]);
                sy = int.Parse(start[1]);
                ex = int.Parse(end[0]);
                ey = int.Parse(end[1]);
                off = true;
            }
            else
            {
                string[] parts = line.Substring(7).Split(" through ");
                string[] start = parts[0].Split(',');
                string[] end = parts[1].Split(',');
                sx = int.Parse(start[0]);
                sy = int.Parse(start[1]);
                ex = int.Parse(end[0]);
                ey = int.Parse(end[1]);
                toggle = true;
            }

            for (int x = sx; x <= ex; x++)
            {
                for (int y = sy; y <= ey; y++)
                {
                    if (on) lights[x,y] = true;
                    if (off) lights[x,y] = false;
                    if (toggle) lights[x,y] = !lights[x,y];
                }
            }
        }

        int lit = 0;
        for (int x = 0; x < 1000; x++)
        {
            for (int y = 0; y < 1000; y++)
            {
                if (lights[x,y]) lit++;
            }
        }

        Console.WriteLine(lit);
    }

    public static void Ex2()
    {
        string[] lines = File.ReadAllLines("201506.txt");
        int[,] lights = new int[1000,1000];

        foreach (string line in lines)
        {
            bool on = false;
            bool off = false;
            bool toggle = false;
            int sx, sy, ex, ey;
            if (line.StartsWith("turn on "))
            {
                string[] parts = line.Substring(8).Split(" through ");
                string[] start = parts[0].Split(',');
                string[] end = parts[1].Split(',');
                sx = int.Parse(start[0]);
                sy = int.Parse(start[1]);
                ex = int.Parse(end[0]);
                ey = int.Parse(end[1]);
                on = true;
            }
            else if (line.StartsWith("turn off "))
            {
                string[] parts = line.Substring(9).Split(" through ");
                string[] start = parts[0].Split(',');
                string[] end = parts[1].Split(',');
                sx = int.Parse(start[0]);
                sy = int.Parse(start[1]);
                ex = int.Parse(end[0]);
                ey = int.Parse(end[1]);
                off = true;
            }
            else
            {
                string[] parts = line.Substring(7).Split(" through ");
                string[] start = parts[0].Split(',');
                string[] end = parts[1].Split(',');
                sx = int.Parse(start[0]);
                sy = int.Parse(start[1]);
                ex = int.Parse(end[0]);
                ey = int.Parse(end[1]);
                toggle = true;
            }

            for (int x = sx; x <= ex; x++)
            {
                for (int y = sy; y <= ey; y++)
                {
                    if (on) lights[x,y]++;
                    if (off) 
                    {
                        lights[x,y] = Math.Max(lights[x, y] - 1, 0);
                    }
                    if (toggle) lights[x,y] += 2;
                }
            }
        }

        long brightness = 0;
        for (int x = 0; x < 1000; x++)
        {
            for (int y = 0; y < 1000; y++)
            {
                brightness += lights[x, y];
            }
        }

        Console.WriteLine(brightness);
    }
}
