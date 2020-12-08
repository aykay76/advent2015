using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

class Year2015Day4
{
    public static void Ex1()
    {
        int i = 1;
        byte[] hash = null;
        MD5 md5 = MD5.Create();
        while (true)
        {
            string s = string.Format("yzbqklnj{0}", i);
            hash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(s));

            if (hash[0] == 0 && hash[1] == 0 && (hash[2] & 0xf0) == 0)
            {
                Console.WriteLine(i);
                break;
            }

            i++;
        }
    }

    public static void Ex2()
    {
        int i = 1;
        byte[] hash = null;
        MD5 md5 = MD5.Create();
        while (true)
        {
            string s = string.Format("yzbqklnj{0}", i);
            hash = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(s));

            if (hash[0] == 0 && hash[1] == 0 && hash[2] == 0)
            {
                Console.WriteLine(i);
                break;
            }

            i++;
        }
    }
}
