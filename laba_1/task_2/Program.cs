using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"Samsung", 20000},
                {"Apple", 35000},
                {"Xiaomi", 10000},
                {"Asus", 25000}
            };


            int maxValue = dictionary.Max(x => x.Value);
            int minValue = dictionary.Min(x => x.Value);


            foreach (var kvp in dictionary.ToList())
            {
                if (kvp.Value == maxValue || kvp.Value == minValue)
                    dictionary.Remove(kvp.Key);
            }


            var sortedDictionary = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            string json = JsonSerializer.Serialize<Dictionary<string,int>>(sortedDictionary);
            File.WriteAllText("B:\\kpi\\ООП\\semeseter_2\\laba_1\\laba_1\\task_2\\result.json", json);
        }
    }
}
