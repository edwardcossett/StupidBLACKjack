using StupidBlackjackSln.Code;
using StupidBlackjackSln.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBlackjackSln {
  public partial class FrmNewGame : Form {
    private Deck deck;
    private BlackjackPlayer player;
    private Dealer dealer;
    private PictureBox[] picPlayerCards;
    private PictureBox[] picDealerCards;
    private int streakCounter;

    public Dealer Dealer { get => dealer; set => dealer = value; }
    public int StreakCounter { get => streakCounter; set => streakCounter = value; }

    public FrmNewGame(string playerName) {
      InitializeComponent();

      picPlayerCards = new PictureBox[5];
      picDealerCards = new PictureBox[5];

      player = new BlackjackPlayer();
      lblPlayerName.Text = playerName;
      streakCounter = 0;

      player.SetName(playerName);
      
      dealer = new BlackjackDealer();

      for (int i = 0; i < 5; i++) {
        Console.WriteLine(i);
        picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
      }
      for (int i = 0; i < 5; i++) {
        Console.WriteLine(i);
        picDealerCards[i] = Controls.Find("picDealerCard" + (i + 1).ToString(), true)[0] as PictureBox;
      }
    }

    private void FrmNewGame_Load(object sender, EventArgs e) {
      deck = new Deck(FindBitmap);

      lblPlayerStreak.Text = streakCounter.ToString();
      player.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      showHand();
    }

    private void showHand() {
      for (int i = 0; i < player.Hand.Count(); i++) {
        picPlayerCards[i].BackgroundImage = player.Hand[i].Bitmap;
      }
      for (int i = 0; i < dealer.Hand.Count(); i++) {
        picDealerCards[i].BackgroundImage = dealer.Hand[i].Bitmap;
      }
      lblPlayerScore.Text = player.Score.ToString();
      if(player.Hand.Count()==5 && player.Score <= 21)
            {
                DialogResult result = MessageBox.Show("You Win! Start New Game?", "You Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    frmTitle frmTitle = new frmTitle();
                    frmTitle.Show();
                    this.Hide();
                }
            }
    }

    private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e) {
      foreach (Form f in Application.OpenForms) {
        f.Close();
      }
    }

    private void btnHit_Click(object sender, EventArgs e) {
      player.giveCard(deck.dealCard());
      showHand();
            System.Threading.Thread.Sleep(200);
            if (player.Score > 21)
            {
                streakCounter = 0;
                DialogResult result = MessageBox.Show("You Lose! Start New Game?", "You Lose!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    frmTitle frmTitle = new frmTitle();
                    frmTitle.Show();
                    this.Hide();
                }
            }
    }

    private void btnStand_Click(object sender, EventArgs e)
    {
            while (dealer.Score<player.Score && dealer.Score < 17)
            {
                dealer.giveCard(deck.dealCard());
                showHand();
                System.Threading.Thread.Sleep(500);
                
            }
            if (dealer.Score > 21)
            {
                streakCounter += 1;
                DialogResult result = MessageBox.Show("You Win! Start New Game?", "You Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    frmTitle frmTitle = new frmTitle();
                    frmTitle.Show();
                    this.Hide();
                }
            }
            else if (player.Score <= dealer.Score)
            {
                streakCounter = 0;
                DialogResult result = MessageBox.Show("You Lose! Start New Game?", "You Lose!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    frmTitle frmTitle = new frmTitle();
                    frmTitle.Show();
                    this.Hide();
                }
            }
            else
            {
                streakCounter += 1;
                DialogResult result = MessageBox.Show("You Win! Start New Game?", "You Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    frmTitle frmTitle = new frmTitle();
                    frmTitle.Show();
                    this.Hide();
                }
            }
        }

    private void startNewGame()
        {
            player.Hand.Clear();
            dealer.Hand.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                picPlayerCards[i].BackgroundImage = null;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                picDealerCards[i].BackgroundImage = null;
            }

            lblPlayerStreak.Text = streakCounter.ToString();
            deck = new Deck(FindBitmap);
            player.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard()});
            dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard()});
            showHand();
        }

    private Bitmap FindBitmap(string value, string suit) {
      string textName = "";
      int valueAsNum;
            if (value == "back_of_card")
            {
                return (Bitmap)Resources.ResourceManager.GetObject(value);

            }
      if (int.TryParse(value, out valueAsNum)) {
        textName += "_";
      }

      textName += value;
      textName += "_of_";
      textName += suit;

      return (Bitmap)Resources.ResourceManager.GetObject(textName);
    }

        
    }
}
