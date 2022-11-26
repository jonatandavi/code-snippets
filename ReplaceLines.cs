using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReplaceLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter with file name: ");
            string filePath = Console.ReadLine();

            Console.Write("Enter wit the array of words (separate by comma): ");
            string keys = Console.ReadLine().Split(',');

            Console.Write("Enter with the old value: ");
            string oldValue = Console.ReadLine();

            Console.Write("Enter with the new value: ");
            string newValue = Console.ReadLine();

            string[] lines = File.ReadAllLines(filePath);
            string[] new_lines = new string[lines.Count()];

            for (int i = 0; i < lines.Count(); i++)
            {
                foreach(string tag in keys)
                {
                    new_lines[i] = lines[i];
                    if (lines[i].Contains(tag))
                    {
                        new_lines[i] = lines[i].Replace(oldValue, newValue);

                        Console.WriteLine(lines[i] + " -> " + new_lines[i]);
                    }
                }
            }
            System.IO.File.WriteAllLines(filePath, new_lines);
        }
    }
}
