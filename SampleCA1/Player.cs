using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1
{
    class Player
    {
        //Short hand properties for Player ID
        //Player ID is a read only accessor
        public int PlayerId { get; }

        //Short hand property for Player Name
        public string  PlayerName { get; set; }

        //Short hand property for Player Score
        public int Score { get; private set; }

        public Player(int playerId, string playerName, int score)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            Score = score;
        }

        //Method to add score to player
        public void IncreaseScore(int valueToAdd)
        {
            if (Score < 100)
            Score += valueToAdd;
        }
    }
}
