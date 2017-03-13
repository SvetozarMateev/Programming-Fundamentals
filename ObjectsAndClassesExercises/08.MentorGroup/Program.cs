using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Student
{
    public string Name { get; set; }
    public List<string> Comments { get; set; }
    public List<DateTime> Dates { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Student> nameToProperties = new Dictionary<string, Student>();
        Dictionary<string, List<DateTime>> dates = new Dictionary<string, List<DateTime>>();
        Dictionary<string, List<string>> comments = new Dictionary<string, List<string>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input[0] == "end")
                break;
            Student Pesho = new Student();
            Pesho.Dates = new List<DateTime>();
            Pesho.Name = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                DateTime date = DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
               
                 Pesho.Dates.Add(date);
            }
            if (nameToProperties.ContainsKey(Pesho.Name) == false)
                nameToProperties.Add(Pesho.Name, Pesho);
            else
                nameToProperties[Pesho.Name].Dates.AddRange(Pesho.Dates);
            if (dates.ContainsKey(Pesho.Name) == false)
                dates[Pesho.Name] = new List<DateTime>();
            dates[Pesho.Name].AddRange(Pesho.Dates);
            
        }
        while (true)
        {
            string checker = Console.ReadLine();
            string[] input = checker.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (checker == "end of comments")
                break;
            Student pesho = new Student();
            pesho.Comments = new List<string>();
            if (nameToProperties.ContainsKey(input[0]))
            {
                for (int i = 1; i < input.Length; i++)
                {
                   pesho.Comments.Add(input[i]);

                }
                if (comments.ContainsKey(input[0]) == false)
                    comments.Add(input[0], pesho.Comments);
                else
                    comments[input[0]].AddRange(pesho.Comments);
            }

        }
        foreach (var item in nameToProperties.OrderBy(x=>x.Key))
        {
            nameToProperties[item.Key].Dates.Sort();
            Console.WriteLine($"{item.Key}");
            Console.WriteLine("Comments:");

            foreach (var pair in comments)
            {
                
                if (pair.Key == item.Key)
                {
                    for (int i = 0; i < pair.Value.Count; i++)
                    {
                        Console.WriteLine($"- {pair.Value[i]}");
                    }
                }
            }
            
            Console.WriteLine("Dates attended:");
            nameToProperties[item.Key].Dates.Sort();
            for (int i = 0; i < nameToProperties[item.Key].Dates.Count; i++)
            {
                DateTime current = new DateTime(nameToProperties[item.Key].Dates[i].Year, nameToProperties[item.Key].Dates[i].Month, nameToProperties[item.Key].Dates[i].Day);
                Console.WriteLine($"-- {current.Day.ToString().PadLeft(2,'0')}/{current.Month.ToString().PadLeft(2,'0')}/{current.Year}");
            }
        }
       
    }
}

