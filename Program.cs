using System;
using System.IO;
using System.Collections.Generic;

namespace Practic23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Dictionary<char, int> stat = new Dictionary<char, int>();
            //
            //using (FileStream stream = new FileStream(@C:\Users\Андрей\source\repos\Practic23\Practic23\Practic23.csproj, FileMode.OpenOrCreate))
            //{
            //    byte[] bytes = new byte[stream.Length];
            //
            //    stream.Read(bytes, 0, bytes.Length);
            //
            //    string data = System.Text.Encoding.Unicode.GetString(bytes);
            //    foreach (char symbol in data)
            //    {
            //        if (stat.ContainsKey(symbol))
            //        {
            //            stat[symbol]++;
            //        }
            //        else
            //        {
            //            stat[symbol] = 0;
            //        }
            //    }
            //    Console.WriteLine(data);
            //}
            //foreach (KeyValuePair<char, int> item in stat)
            //{
            //    Console.WriteLine(item.Key + "\t\t" + item.Value);
            //}

            //Task 2
            //string path = @"C:\Users\Андрей\source\repos\Practic23\Practic23\Practic23.csproj";
            //using (StreamWriter stream = new StreamWriter(path))
            //{
            //    stream.WriteLine("Anrew");
            //    stream.WriteLine("Kan");
            //    stream.WriteLine("16");
            //}
            //Console.ReadLine();


        }
    }
}
