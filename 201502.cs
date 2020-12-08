using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Year2015Day2
{
    public static void Ex1()
    {
        string[] lines = File.ReadAllLines("201502.txt");

        int totalPaper = 0;
        foreach (string line in lines)
        {
            string[] parts = line.Split('x');
            int[] dimensions = new int[3];
            for (int i = 0; i < 3; i++)
            {
                dimensions[i] = int.Parse(parts[i]);
            }

            int[] faces = new int[3];
            for (int i = 0; i < 3; i++)
            {
                faces[i] = dimensions[i] * dimensions[(i + 1) % 3];
            }

            int paper = faces[0] * 2 + faces[1] * 2 + faces[2] * 2;
            paper += faces.Min();

            totalPaper += paper;
        }

        Console.WriteLine(totalPaper);
    }

    public static void Ex2()
    {
        string[] lines = File.ReadAllLines("201502.txt");

        int totalRibbon = 0;
        foreach (string line in lines)
        {
            string[] parts = line.Split('x');
            List<int> dimensions = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                dimensions.Add(int.Parse(parts[i]));
            }

            int volume = dimensions[0] * dimensions[1] * dimensions[2];

            dimensions.Remove(dimensions.Max());

            foreach (var d in dimensions)
            {
                totalRibbon += 2 * d;
            }
            totalRibbon += volume;
        }

        Console.WriteLine(totalRibbon);
    }
}
