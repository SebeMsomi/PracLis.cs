using System;
using System.Collections.Generic;

namespace PracLis.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            int[] arr = new int[] { 1, 2, 3 };

            numbers.AddRange(arr);
            numbers.Remove(2);
            Console.WriteLine(numbers.Count);

            //dictionaries
            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("Sebzza", 0844115584);
            phonebook["Parlie"] = 44555444;

            if (phonebook.ContainsKey("Sebzza"))
            {
                Console.WriteLine("Sebzza's number is " + phonebook["Sebzza"]);
            }

            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory["apple"] = 3;
            inventory["orange"] = 5;
            inventory["banana"] = 2;

            Console.WriteLine(inventory["apple"]);
            Console.WriteLine(inventory["orange"]);
            Console.WriteLine(inventory["banana"]);

        }
    }
}
