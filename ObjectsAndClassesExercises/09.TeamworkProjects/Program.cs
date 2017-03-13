using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Team
{
    public string Creator { get; set; }
    public string Name { get; set; }
    public List<string> Members { get; set; }
    public bool Existence { get; set; }
    public string Invalid { get; set; }
    public string DuplicationAttempt { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Team> listOfTeams = new List<Team>();
        List<string> teamNames = new List<string>();
        List<string> occupiedPeople = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split('-').ToArray();
            Team team = new Team();
            team.Creator = input[0];
            team.Name = input[1];
            team.Existence = true;
            if (teamNames.Contains(input[1]) == false)
            {
                listOfTeams.Add(team);
                occupiedPeople.Add(input[0]);
                teamNames.Add(input[1]);
            }
            else
            {
                for (int a = 0; a < listOfTeams.Count; a++)
                {
                    if (listOfTeams[a].Name == input[1])
                    {
                        Team doubleTeam = new Team();
                        doubleTeam.DuplicationAttempt = input[1];
                        doubleTeam.Name = "a"+ input[1];
                        listOfTeams.Add(doubleTeam);
                    }
                }
            }
            
        }
        while (true)
        {
            string checker = Console.ReadLine();
            if(checker== "end of assignment")
            {
                break;
            }
            string[] input = checker.Split(new[] { '>', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (teamNames.Contains(input[1]))
            {
                if (occupiedPeople.Contains(input[0]) == false)
                {
                    for (int i = 0; i < listOfTeams.Count; i++)
                    {
                        if (input[1] == listOfTeams[i].Name)
                        {
                            if (listOfTeams[i].Members == null)
                            {
                                listOfTeams[i].Members = new List<string>();
                            }
                            listOfTeams[i].Members.Add(input[0]);
                            occupiedPeople.Add(input[0]);
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < listOfTeams.Count; i++)
                    {
                        if (input[1] == listOfTeams[i].Name)
                        {
                            listOfTeams[i].Invalid = input[0];
                        }
                    }
                }
            }
            else
            {
                Team team = new Team();
                team.Existence = false;
                team.Name = "b"+input[1];
                listOfTeams.Add(team);
            }
        }
        for (int i = 0; i < listOfTeams.Count; i++)
        {
            if (listOfTeams[i].DuplicationAttempt == null && teamNames.Contains(listOfTeams[i].Name))
            {
                Console.WriteLine($"Team {listOfTeams[i].Name} has been created by {listOfTeams[i].Creator}!");
            }
            else if(listOfTeams[i].DuplicationAttempt!=null)
            {
                char[] arr = listOfTeams[i].Name.ToCharArray();

                string name = new string(arr, 1, arr.Length - 1);
                Console.WriteLine($"Team {name} was already created!");
            }
        }
        for (int i = 0; i < listOfTeams.Count; i++)
        {
            if (listOfTeams[i].Existence == false&&listOfTeams[i].DuplicationAttempt==null)
            {
                char[] arr = listOfTeams[i].Name.ToCharArray();
                string name = new string(arr,1,arr.Length-1);
                Console.WriteLine($"Team {name} does not exist!");
            }
            else if (listOfTeams[i].Invalid != null && teamNames.Contains(listOfTeams[i].Name))
            {
                Console.WriteLine($"Member {listOfTeams[i].Invalid} cannot join team {listOfTeams[i].Name}!");
            }
        }
        List<string> disbaned = new List<string>();
        for (int i = 0; i < listOfTeams.Count; i++)
        {
            if (teamNames.Contains(listOfTeams[i].Name))
            {
                if (listOfTeams[i].Members == null)
                {
                    disbaned.Add(listOfTeams[i].Name);
                }
                else if(listOfTeams[i].Members.Count<1)
                {
                    disbaned.Add(listOfTeams[i].Name);
                }
            }
        }
        //maybe a mistake
        listOfTeams = listOfTeams.Where(x => x.Members != null).ToList();
        listOfTeams = listOfTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
        for (int i = 0; i < listOfTeams.Count; i++)
        {
            listOfTeams[i].Members.Sort();
            Console.WriteLine(listOfTeams[i].Name);
            Console.WriteLine($"- {listOfTeams[i].Creator}");
            for (int a = 0; a < listOfTeams[i].Members.Count; a++)
            {
                Console.WriteLine($"-- {listOfTeams[i].Members[a]}");
            }
        }
        Console.WriteLine("Teams to disband:");
        disbaned=disbaned.OrderBy(x => x).ToList();
        for (int i = 0; i < disbaned.Count; i++)
        {           
            Console.WriteLine(disbaned[i]);
        }
    }
}


