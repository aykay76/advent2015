using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

class Year2015Day7
{
    public static void Ex1()
    {
        string[] lines = File.ReadAllLines("201507.txt");

        Dictionary<string, ushort> wires = new Dictionary<string, ushort>();

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(" -> ");
            string target = parts[1];
            string[] operands = parts[0].Split(' ');

            if (operands.Length == 1)
            {
                ushort value = 0;

                if (!ushort.TryParse(operands[0], out value))
                {
                    value = wires.ContainsKey(operands[0])?wires[operands[0]]:0;
                }

                wires[target] = value;
            }
            else if (operands.Length == 2)
            {
                if (operands[0] == "NOT")
                {
                    string source = operands[1];
                    ushort value = wires.ContainsKey(source)?wires[source]:0;

                    wires[target] = (ushort)~value;
                }
            }
            else if (operands.Length == 3)
            {
                if (operands[1] == "AND")
                {
                    ushort v1 = wires.ContainsKey(operands[0])?wires[operands[0]]:0;
                    ushort v2 = wires.ContainsKey(operands[2])?wires[operands[2]]:0;
                    wires[target] = (ushort)(v1 & v2);
                }
                else if (operands[1] == "OR")
                {
                    ushort v1 = wires.ContainsKey(operands[0])?wires[operands[0]]:0;
                    ushort v2 = wires.ContainsKey(operands[2])?wires[operands[2]]:0;
                    wires[target] = (ushort)(v1 | v2);
                }
                else if (operands[1] == "LSHIFT")
                {
                    ushort v1 = wires.ContainsKey(operands[0])?wires[operands[0]]:0;
                    ushort v2 = ushort.Parse(operands[2]);
                    wires[target] = (ushort)(v1 << v2);
                }
                else if (operands[1] == "RSHIFT")
                {
                    ushort v1 = wires.ContainsKey(operands[0])?wires[operands[0]]:0;
                    ushort v2 = ushort.Parse(operands[2]);
                    wires[target] = (ushort)(v1 >> v2);
                }
            }
        }

        Console.WriteLine(wires["a"]);
    }

    public static void Ex2()
    {
        string[] lines = File.ReadAllLines("201507.txt");
    }
}
