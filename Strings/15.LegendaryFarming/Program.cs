using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> legendary = new Dictionary<string, long>();
            Dictionary<string, long> junk = new Dictionary<string, long>();
            legendary.Add("motes", 0);
            legendary.Add("fragments", 0);
            legendary.Add("shards", 0);

            bool valanyr = false;
            bool dragonwrath = false;
            bool shadowmourne = false;
            while (true)
            {
                long quantity = 0;
                string item = "";
                List<string> inputLine = Console.ReadLine().Split(' ').ToList();
                for (int i = 0; i < inputLine.Count - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = long.Parse(inputLine[i]);
                        item = inputLine[i + 1].ToLower();
                        if (item == "motes" | item == "shards" | item == "fragments" && valanyr == false && dragonwrath == false && shadowmourne == false)
                        {
                            if (legendary.ContainsKey(item) == false)
                            {
                                legendary.Add(item, quantity);
                            }
                            else if (legendary[item] >= 250 == false)
                            {
                                legendary[item] += quantity;
                            }
                            foreach (var pair in legendary)
                            {
                                if (legendary[pair.Key] >= 250)
                                {
                                    if (pair.Key == "motes")
                                    {
                                        dragonwrath = true;
                                    }
                                    else if (pair.Key == "fragments")
                                    {
                                        valanyr = true;
                                    }
                                    else
                                    {
                                        shadowmourne = true;
                                    }
                                }
                            }
                        }
                        else if (valanyr == false && dragonwrath == false && shadowmourne == false)
                        {
                            if (junk.ContainsKey(item) == false)
                            {
                                junk.Add(item, quantity);
                            }

                            else
                            {
                                junk[item] += quantity;
                            }
                        }
                    }
                }
                foreach (var pair in legendary)
                {
                    if (legendary[pair.Key] >= 250)
                    {
                        if (pair.Key == "motes")
                        {
                            dragonwrath = true;
                            legendary[pair.Key] -= 250;
                        }
                        else if (pair.Key == "fragments")
                        {
                            valanyr = true;
                            legendary[pair.Key] -= 250;
                        }
                        else if (pair.Key == "shards")
                        {
                            shadowmourne = true;
                            legendary[pair.Key] -= 250;
                        }
                        break;
                    }
                }
                if (dragonwrath == true | valanyr == true | shadowmourne == true)
                    break;
            }
            if (dragonwrath == true)
                Console.WriteLine("Dragonwrath obtained!");
            else if (valanyr == true)
                Console.WriteLine("Valanyr obtained!");
            else
                Console.WriteLine("Shadowmourne obtained!");
           
            foreach (var thing in legendary.OrderByDescending(thing => thing.Value).ThenBy(k=>k.Key))
            {
                Console.WriteLine("{0}: {1}", thing.Key, thing.Value);
            }
            foreach (var pair in junk.OrderBy(pair => pair.Key))
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}

