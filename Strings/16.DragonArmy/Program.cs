using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, Dictionary<string, int>>> result = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
            string[] words = new string[5];
            List<string[]> allWords = new List<string[]>();
            for (int i = 0; i < n; i++)
            {
                words = Console.ReadLine().Split(' ').ToArray();
                allWords.Add(words);
            }
            for (int i = 0; i < n; i++)
            {
                Dictionary<string, int> skillsValue = new Dictionary<string, int>();
                Dictionary<string, Dictionary<string, int>> nameToAtributes = new Dictionary<string, Dictionary<string, int>>();
                skillsValue.Add("damage", 45);
                skillsValue.Add("health", 250);              
                skillsValue.Add("armor", 10);
                string type = allWords[i][0];
                string name = allWords[i][1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                if(allWords[i][2]!= "null")              
                     damage = int.Parse(allWords[i][2]);               
                if (allWords[i][3] != "null")                
                    health = int.Parse(allWords[i][3]);              
                if (allWords[i][4] != "null")               
                    armor = int.Parse(allWords[i][4]);
                                              
                skillsValue["health"] = health;
                skillsValue["damage"] = damage;
                skillsValue["armor"] = armor;
                nameToAtributes.Add(name, skillsValue);
                if (result.ContainsKey(type)== false)               
                    result.Add(type, nameToAtributes);                                    
                else
                {
                    if (result[type].ContainsKey(name)==false)
                        result[type].Add(name, skillsValue);
                    else                                       
                        result[type][name] = skillsValue;                 
                }
            }
            foreach (var item in result)
            {               
                Console.Write("{0}::",item.Key);
                decimal AD = 0.0m;
                decimal AH = 0.0m;
                decimal AA = 0.0m;
                List<decimal> averageDamage = new List<decimal>();
                List<decimal> averageHealth = new List<decimal>();
                List<decimal> averageArmor = new List<decimal>();
                foreach (var pair in item.Value)
                {              
                    foreach (var couple in pair.Value)
                    {                      
                        if (couple.Key == "damage")                       
                            averageDamage.Add(couple.Value);
                        
                        else if(couple.Key == "health")                       
                            averageHealth.Add(couple.Value);
                        
                        else if (couple.Key == "armor")                      
                            averageArmor.Add(couple.Value);                        
                    }
                    AD = averageDamage.Average();
                    AH = averageHealth.Average();
                    AA = averageArmor.Average();                   
                }
                Console.WriteLine("({0:f2}/{1:f2}/{2:f2})", AD, AH, AA);
                foreach (var pair in item.Value.OrderBy(x=> x.Key))
                {
                    Console.Write("-{0} -> ", pair.Key);
                    foreach (var couple in pair.Value)
                    {
                        if (couple.Key == "armor") 
                            Console.WriteLine("{0}: {1}",couple.Key, couple.Value);                        
                        else
                            Console.Write("{0}: {1}, ", couple.Key, couple.Value);
                    }
                }
            }
        }
    }

