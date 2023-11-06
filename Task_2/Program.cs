using Task_2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Footman> footmans = new List<Footman>();
        List<RoyalGuard> royalGuards = new List<RoyalGuard>();

        RoyalGuard royalGuard;
        Footman footman;

        string kingName = Console.ReadLine();
        King king = new King(kingName);
        string[] royalName = Console.ReadLine().Split(' ');
        for(int i = 0; i < royalName.Length; i++)
        {
            royalGuard = new RoyalGuard(royalName[i]);
            royalGuards.Add(royalGuard);
        }
        string[] footmanName = Console.ReadLine().Split(' ');
        for (int i = 0; i < footmanName.Length; i++)
        {
            footman = new Footman(footmanName[i]);
            footmans.Add(footman);
        }

        king.AttackEvent += (sender,args) =>
        {
            Console.WriteLine(args.Message);
            foreach (RoyalGuard royalGuard in royalGuards)
            {
                royalGuard.RespondToAttack();
            }
            foreach (Footman footman in footmans)
            {
                footman.RespondToAttack();
            }
        };
        

        string inputCommands;
        while ((inputCommands = Console.ReadLine().ToLower()) != "end")
        {
            string[] commands = inputCommands.Split(" ");
            if (commands[0] == "Attack")
            {
                king.RespondToAttack();
            }
            if (commands[0] == "Kill")
            {
                string name = commands[1];
                KillUnit(royalGuards, footmans, name);
            }
        }
    }
    static void KillUnit(List<RoyalGuard> royalGuards, List<Footman> footmen, string name)
    {
        RoyalGuard royalGuard = royalGuards.FirstOrDefault(r => r.Name == name);
        Footman footman = footmen.FirstOrDefault(f => f.Name == name);

        if (royalGuard != null)
        {
            royalGuards.Remove(royalGuard);
        }
        else if (footman != null)
        {
            footmen.Remove(footman);
        }
    }
}