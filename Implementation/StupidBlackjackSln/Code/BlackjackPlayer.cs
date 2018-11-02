using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBlackjackSln.Code {
  class BlackjackPlayer : Player {
        private string name;

        /// <summary>
        /// Used to identify players and facilitate the tracking of their data
        /// </summary>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Used to identify players and facilitate the tracking of their data
        /// </summary>
        public void SetName(string value)
        {
            name = value;
        }

        protected override void calcScore() {
      this.Score = 0;
      int numAces = 0;
      foreach (Card card in Hand) {
        int value;
        string cardValue = card.getValue();
        // 2 - 10
        if (int.TryParse(cardValue, out value)) {
          Score += value;
        }
        // jack, queen, king
        else if (!cardValue.ToLower().Equals("ace")) {
          Score += 10;
        }
        // ace
        else {
          numAces++;
          Score += 11;
        }
      }

      if (this.Score > 21) {
        while (numAces > 0) {
          Score -= 10;
          if (this.Score > 21) {
            numAces--;
            continue;
          }
          break;
        }
      }
    }
    /// <summary>
    /// This function will check the player's name and current streak to a local csv file named currentStreaks
    /// It will then check another local csv file named leaderboardStatus and update accordingly
    /// q's: should I load streak from the csv, if so when? probably load it when a player names itself
    /// where is current streak kept? probably in the player
    /// handle nameless players? think im just gonna not let them be saved into the csv
    /// </summary>
    private void trackStreak() {

        }
  }
}
