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
            player1.IncreaseScore(1);
            player2.IncreaseScore(10);
        }
    }
}
