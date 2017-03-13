using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    public string Type { get; set; }
    public decimal Price { get; set; }   
}
class Customer
{
    public string Name { get; set; }   
    public int Quantity { get; set; }
    public string Type { get; set; }
    public decimal PriceOfItem { get; set; }
    
}
class Program
{
    static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, decimal> listOfItems = new Dictionary<string, decimal>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', ',', '-' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            Product entry = new Product();
            entry.Type = input[0];
            entry.Price = decimal.Parse(input[1]);
            listOfItems[entry.Type] = entry.Price;

        }
        Dictionary<string, List<Dictionary<string, decimal>>> nameToProductToPrice = new Dictionary<string, List<Dictionary<string, decimal>>>();
        Dictionary<string, Dictionary<string, int>> nameToProductToQuantity = new Dictionary<string, Dictionary<string, int>>();
        while (true)
        {
            string[] checker = Console.ReadLine().Split(new[] { ' ', ',', '-' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (checker[0] == "end" && checker[1] == "of")
                break;
            Customer someone = new Customer();
            if (listOfItems.ContainsKey(checker[1]))
            {
                someone.Name = checker[0];
                someone.Quantity= int.Parse(checker[2]);
                someone.Type = checker[1];
                someone.PriceOfItem = listOfItems[checker[1]]*someone.Quantity;
                Dictionary<string, decimal> productToPrice = new Dictionary<string, decimal>();               
                productToPrice.Add(checker[1], someone.PriceOfItem);
                Dictionary<string, int> productToQuantity = new Dictionary<string, int>();
                productToQuantity.Add(someone.Type, someone.Quantity);
                if(nameToProductToQuantity.ContainsKey(someone.Name)==false)
                    nameToProductToQuantity.Add(someone.Name, productToQuantity);
               
                if (nameToProductToPrice.ContainsKey(someone.Name) == false)
                {
                    nameToProductToPrice[someone.Name] = new List<Dictionary<string, decimal>>();
                }
                bool repeated = false;
                for (int i = 0; i < nameToProductToPrice[someone.Name].Count; i++)
                {
                    foreach (var pair in productToPrice)
                    {
                        if (nameToProductToPrice[someone.Name][i].ContainsKey(pair.Key))
                        {
                            repeated = true;
                            nameToProductToPrice[someone.Name][i][pair.Key] += pair.Value;
                        }
                    }
                            

                        
                }
                if(!repeated)
                nameToProductToPrice[someone.Name].Add(productToPrice);
                              
            }          
        }
        decimal wholeBill = 0;
        foreach (var pair in nameToProductToPrice.OrderBy(x=>x.Key))
        {
            Console.WriteLine(pair.Key);
            decimal personalBill = 0;
            for (int i = 0; i < pair.Value.Count; i++)
            {
                foreach (var couple in pair.Value[i])
                {
                    if(listOfItems[couple.Key]!=0)
                        Console.WriteLine($"-- {couple.Key} - {couple.Value / listOfItems[couple.Key]}");
                    else
                        Console.WriteLine($"-- {couple.Key} - {nameToProductToQuantity[pair.Key][couple.Key]}");
                    personalBill += couple.Value;
                }
            }
           
            Console.WriteLine($"Bill: {personalBill:f2}");
            wholeBill += personalBill;
        }
        Console.WriteLine($"Total bill: {wholeBill:f2}");
    }
}

