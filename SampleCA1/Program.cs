using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            //Creating a list of player to hold all player objects
            List<Player> allPLayers = new List<Player>();
            allPLayers.Add(player1);
            allPLayers.Add(player2);
            allPLayers.Add(player3);
            allPLayers.Add(player4);
            allPLayers.Add(player5);

            //Adding player scores using the Increase Score method
            //player1.IncreaseScore(1);
            //player2.IncreaseScore(10);

            //Calling the display method
            Display(allPLayers);
            
            //Calling the Get Scores method
            GetScores(allPLayers);
        }

        private static void GetScores(List<Player> allPLayers)
        {
            //Loop to ask user to enter the number of the player they want to update the score of
            Console.WriteLine("Please enter number of Player you wish to add score for: ");
            string response = Console.ReadLine();
            int playerNumber = int.Parse(response);

            while (playerNumber != 0)
            {
                //Determine Player selected
                Player selectedPlayer = allPLayers.ElementAt(playerNumber - 1);//using minus 1 as index starts at 0

                //Increase score for that player
                selectedPlayer.IncreaseScore(1);

                //Displaye results
                Display(allPLayers);

                //Ask for another number or 0 to quit
                Console.WriteLine("Please enter number of Player you wish to add score for: ");
                response = Console.ReadLine();
                playerNumber = int.Parse(response);


            }//end of while loop
        }

        //Adding method to display player scores
        private static void Display(List<Player> players)
        {
            Console.WriteLine("{0, -10}{1, -10}{2, -10}{3, -10}{4, -10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");

            //Loop through all players in list and display scores for each player
            foreach (Player player in players)
            {
                Console.Write("{0, -10}", player.Score);
            }

            Console.WriteLine();//Add new line at end of scores
        }
    }
}
