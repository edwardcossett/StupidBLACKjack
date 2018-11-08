using StupidBlackjackSln.Code;
using StupidBlackjackSln.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace StupidBlackjackSln
{
    public partial class FrmNewGame : Form {
        private Deck deck;
        private BlackjackPlayer player;
        private Dealer dealer;
        private PictureBox[] picPlayerCards;
        private PictureBox[] picDealerCards;
        private int streakCounter;
        private bool DealerTurn;

        public Dealer Dealer { get => dealer; set => dealer = value; }
        public int StreakCounter { get => streakCounter; set => streakCounter = value; }

		WindowsMediaPlayer flip = new WindowsMediaPlayer();
		WindowsMediaPlayer win = new WindowsMediaPlayer();
		WindowsMediaPlayer lose = new WindowsMediaPlayer();

		public FrmNewGame(string playerName)
        {
            InitializeComponent();

			flip.settings.autoStart = false;
			win.settings.autoStart = false;
			lose.settings.autoStart = false;
			flip.URL = "flip.mp3";
			win.URL = "win.mp3";
			lose.URL = "lose.mp3";


			picPlayerCards = new PictureBox[5];
            picDealerCards = new PictureBox[5];

            player = new BlackjackPlayer();
            lblPlayerName.Text = playerName;
            streakCounter = 0;

            player.SetName(playerName);
            
            dealer = new BlackjackDealer();

            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine(i);
              picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
            }
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine(i);
              picDealerCards[i] = Controls.Find("picDealerCard" + (i + 1).ToString(), true)[0] as PictureBox;
            }
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
			changeEffectsVolume();

			deck = new Deck(FindBitmap);

            lblPlayerStreak.Text = streakCounter.ToString();
            player.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
            dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
            showHand();
	    }

        private void showHand()
        {
			
			for (int i = 0; i < player.Hand.Count(); i++)
            {
                picPlayerCards[i].BackgroundImage = player.Hand[i].Bitmap;
				flip.controls.play();
			}
            for (int i = 0; i < dealer.Hand.Count(); i++)
            {
                picDealerCards[i].BackgroundImage = dealer.Hand[i].Bitmap;
                if (!DealerTurn && i == 1)
                {
                    picDealerCards[i].BackgroundImage = (Bitmap)Resources.back_of_card;
					flip.controls.play();
				}
            }
            lblPlayerScore.Text = player.Score.ToString();
            if(player.Hand.Count()==5 && player.Score <= 21)
            {
				streakCounter += 1;
				win.controls.play();
				DialogResult result = MessageBox.Show("You Win! Start New Game?", "Five Card Charlie!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    lossRoutines();
                    this.Close();
                }
            }
            if (player.Hand.Count() == 2 && player.Score == 21)
            {
                streakCounter += 1;
				win.controls.play();
				DialogResult result = MessageBox.Show("Blackjack! Start New Game?", "Blackjack!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    lossRoutines();
                    this.Close();
                }
            }
            if (dealer.Hand.Count() == 2 && dealer.Score == 21)
            {
                lossRoutines();
                DealerTurn = true;
                showHand();
				lose.controls.play();
				DialogResult result = MessageBox.Show("You Lose! Start New Game?", "Dealer Blackjack!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e)
            {
		    foreach (Form f in Application.OpenForms)
            {
			    f.Show();
		    } 
	    }

        private void btnHit_Click(object sender, EventArgs e)
        {
            player.giveCard(deck.dealCard());
            showHand();
            if (player.Score > 21)
            {
                lossRoutines();
                DealerTurn = true;
                showHand();
				lose.controls.play();
				DialogResult result = MessageBox.Show("You Lose! Start New Game?", "You Lose!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            DealerTurn = true;
            showHand();
            while (dealer.Score<player.Score || dealer.Score < 17)
            {
                if (dealer.Hand.Count() == 5 && dealer.Score <= 21)
                {
                    lossRoutines();
                    DealerTurn = true;
                    showHand();
					lose.controls.play();
					DialogResult result = MessageBox.Show("You Lose! Start New Game?", "Dealer Five Card Charlie!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        startNewGame();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    dealer.giveCard(deck.dealCard());
                    showHand();
                }
                
            }
            if (dealer.Score > 21)
            {
                streakCounter += 1;
				win.controls.play();
				DialogResult result = MessageBox.Show("You Win! Start New Game?", "You Win!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    lossRoutines();
                    this.Close();
                }
            }
            else if (player.Score < dealer.Score)
            {
				lossRoutines();
				lose.controls.play();
				DialogResult result = MessageBox.Show("You Lose! Start New Game?", "You Lose!", MessageBoxButtons.YesNo);
                DealerTurn = true;
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                   
                    this.Close();
                }
            }
            else if (player.Score == dealer.Score)
            {
                DialogResult result = MessageBox.Show("You pushed! Start New Game?", "You pushed!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
               
                    this.Close();
                }
            }
            else
            {
                streakCounter += 1;
				win.controls.play();
				DialogResult result = MessageBox.Show("You Win! Start New Game?", "You Win!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    startNewGame();
                }
                else
                {
                    lossRoutines();
                    this.Close();
                }
            }
        }

        private void lossRoutines()
        {
            if(!File.Exists("..\\..\\Resources\\input.txt"))
			{
                File.CreateText("..\\..\\Resources\\input.txt");
			}
            using (StreamReader input = File.OpenText("..\\..\\Resources\\input.txt"))
            using (StreamWriter output = new StreamWriter("..\\..\\Resources\\output.txt"))
            {
                string line;
                Boolean found = false;
                int oldScore;
                while (null != (line = input.ReadLine()))
                {
                    if (!found && line.Contains(lblPlayerName.Text))
                    {
                        found = true;
                        string[] stuff = line.Split(':');
                        int.TryParse(stuff[1], out oldScore);
                        if (oldScore < streakCounter)
                            stuff[1] = streakCounter.ToString();
                        line = stuff[0] + ':' + stuff[1];
                    }
                    output.WriteLine(line);
                }
                if (!found)
                {
                    line = lblPlayerName.Text + ':' + streakCounter.ToString();
                    output.WriteLine(line);
                }
            }
            File.Delete("..\\..\\Resources\\input.txt");
            File.Move("..\\..\\Resources\\output.txt", "..\\..\\Resources\\input.txt");
            streakCounter = 0;
        }

        private void startNewGame()
        {
            DealerTurn = false;
            player.Hand.Clear();
            dealer.Hand.Clear();
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(i);
                picPlayerCards[i].BackgroundImage = null;
            }
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine(i);
                picDealerCards[i].BackgroundImage = null;
            }

            lblPlayerStreak.Text = streakCounter.ToString();
            deck = new Deck(FindBitmap);
            player.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard()});
            dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard()});
            showHand();
            
        }

        private Bitmap FindBitmap(string value, string suit)
        {
            string textName = "";
            int valueAsNum;
            if (value == "back_of_card")
            {
                return (Bitmap)Resources.ResourceManager.GetObject(value);

            }
            if (int.TryParse(value, out valueAsNum))
            {
                textName += "_";
            }

            textName += value;
            textName += "_of_";
            textName += suit;

            return (Bitmap)Resources.ResourceManager.GetObject(textName);
        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }
		private void changeEffectsVolume()
		{
			var principalForm = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();
			int volume = principalForm.getEffectsVolume();
			win.settings.volume = volume;
			flip.settings.volume = volume;
			lose.settings.volume = volume;
		}
	}
}

