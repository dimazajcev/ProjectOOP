using ProjectOOP.Enums;
using ProjectOOP.Logic;

namespace ProjectOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Id = 0;
            List<Game> games = new List<Game>();
            while (true)
            {
                try
                {
                    Console.WriteLine("1 - New Game\n2 - Remove save\n3 - Game saves\n4 - Check deck\n0 - Exit");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 0: return;
                        case 1:
                            Deck deck = new Deck();
                            Console.WriteLine("Generated deck\nEnter the number of players"); ;
                            choose = Convert.ToInt32(Console.ReadLine());
                            List<Player> list = new List<Player>();
                            for (int i = 1; i <= choose; i++)
                            {
                                Console.WriteLine("Enter the number of cards to be dealt");
                                int temp = Convert.ToInt32(Console.ReadLine());
                                list.Add(new Player(i, temp, deck.deck));
                            }
                            Game game = new Game(++Id, list, deck);
                            games.Add(game);
                            Console.WriteLine(game.PrintToDisplay());
                            break;
                        case 2:
                            if (!games.Any())
                                throw new Exception("Empty check list!");
                            else
                            {
                                Console.WriteLine("Choose:\n");
                                foreach (Game g in games)
                                {
                                    Console.WriteLine(g.ToString() + "\n");
                                }
                                choose = Convert.ToInt32(Console.ReadLine());
                                games.RemoveAt(choose - 1);
                                Id = games.Count;
                                Console.WriteLine("Removed!");
                            }
                            break;
                        case 3:
                            if (!games.Any())
                                throw new Exception("Empty check list!");
                            else
                            {
                                int i = 0;
                                foreach (Game g in games)
                                    Console.WriteLine(g.PrintToDisplay());
                            }
                            break;
                        case 4:
                            if (!games.Any())
                                throw new Exception("Empty check list!");
                            else
                            {
                                Console.WriteLine("Choose:\n");
                                foreach (Game g in games)
                                {
                                    Console.WriteLine(g.ToString() + "\n");
                                }
                                choose = Convert.ToInt32(Console.ReadLine());
                                List<Cards> copy = (List<Cards>)games[choose - 1].Clone();
                                if (copy != null)
                                    foreach (Cards c in copy)
                                        Console.WriteLine(c);
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}