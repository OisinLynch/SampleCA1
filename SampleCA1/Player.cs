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

        //SHort hand property for Player Score
        public int Score { get; set; }

        public Player(int playerId, string playerName, int score)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            Score = score;
        }
    }
}
