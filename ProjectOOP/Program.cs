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
                    Console.WriteLine("1 - New Game\n2 - Remove save\n3 - Game saves\n4 - Check deck\n5 - Deal the cards\n6 - Change player\n0 - Exit");
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
                        case 5:
                            if (!games.Any())
                                throw new Exception("Empty check list!");
                            else
                            {
                                Console.WriteLine("Choose a game:\n");
                                foreach (Game g in games)
                                {
                                    Console.WriteLine(g.ToString() + "\n");
                                }
                                choose = Convert.ToInt32(Console.ReadLine());
                                Game selectedGame = games[choose - 1];
                                Console.WriteLine("Enter the player number to change cards:");
                                int playerNumber = Convert.ToInt32(Console.ReadLine());
                                selectedGame.Players[playerNumber - 1].PlayerCardCountChanged += Player_PlayerCardCountChanged;
                                Console.WriteLine("Enter the new number of cards for the player:");
                                int newCardCount = Convert.ToInt32(Console.ReadLine());
                                int id = selectedGame.Players[playerNumber - 1].Id;
                                selectedGame.Players[playerNumber - 1] = new Player(id, newCardCount, games[games.Count-1].list);
                            }
                            break;
                        case 6:
                            if (!games.Any())
                                throw new Exception("Empty check list!");
                            else
                            {
                                Console.WriteLine("Choose a game:\n");
                                foreach (Game g in games)
                                {
                                    Console.WriteLine(g.ToString() + "\n");
                                }
                                choose = Convert.ToInt32(Console.ReadLine());
                                Game selectedGame = games[choose - 1];
                                selectedGame.PlayersChanged += Game_PlayersChanged;
                                Console.WriteLine("Enter the number of cards for the new player:");
                                int newPlayerCardCount = Convert.ToInt32(Console.ReadLine());
                                Player newPlayer = new Player(selectedGame.Count + 1, newPlayerCardCount, selectedGame.list);
                                games[choose - 1].Players.Add(newPlayer);
                                Console.WriteLine($"New player added: {newPlayer}");
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
        private static void Player_PlayerCardCountChanged(object sender, EventArgs e)
        {
            Player player = (Player)sender;
            Console.WriteLine($"Player {player.Id} card count changed to {player.Count}");
        }
        private static void Game_PlayersChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Players Changed!");
        }
    }
}