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
    private Player player1;
    private Dealer dealer1;
    private PictureBox[] picPlayerCards;
    private PictureBox[] picDealerCards;

    public FrmNewGame() {
      InitializeComponent();
      picPlayerCards = new PictureBox[5];
      picDealerCards = new PictureBox[5];
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
      player1 = new BlackjackPlayer();
      dealer1 = new BlackjackDealer();
      
      player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      dealer1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      showHand();
    }

    private void showHand() {
      for (int i = 0; i < player1.Hand.Count(); i++) {
        picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
      }
      for (int i = 0; i < dealer1.Hand.Count(); i++) {
        picDealerCards[i].BackgroundImage = dealer1.Hand[i].Bitmap;
      }
      lblPlayerScore.Text = player1.Score.ToString();
    }

    private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e) {
      foreach (Form f in Application.OpenForms) {
        f.Close();
      }
    }

    private void btnHit_Click(object sender, EventArgs e) {
      player1.giveCard(deck.dealCard());
      showHand();
            System.Threading.Thread.Sleep(200);
            if (player1.Score > 21)
            {
                FrmLose frmLose = new FrmLose();
                frmLose.Show();
                this.Hide();
            }
    }

    private void btnStand_Click(object sender, EventArgs e)
    {
            while (dealer1.Score<player1.Score && dealer1.Score < 17)
            {
                dealer1.giveCard(deck.dealCard());
                showHand();
                System.Threading.Thread.Sleep(500);
                
            }
            if (dealer1.Score > 21)
            {
                FrmWin frmWin = new FrmWin();
                frmWin.Show();
                this.Hide();
            }
            else if (player1.Score <= dealer1.Score)
            {
                FrmLose frmLose = new FrmLose();
                frmLose.Show();
                this.Hide();
            }
            else
            {
                FrmWin frmWin = new FrmWin();
                frmWin.Show();
                this.Hide();
            }
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
