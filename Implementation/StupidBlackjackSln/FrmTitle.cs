using StupidBlackjackSln.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace StupidBlackjackSln {
  public partial class frmTitle : Form {
		WindowsMediaPlayer p1 = new WindowsMediaPlayer();
	public frmTitle() {
      InitializeComponent();
	  p1.URL = "background.mp3";
			p1.settings.volume = 25;		
	}

        private String playerName;

        public string GetPlayerName()
        {
            return playerName;
        }

        public void SetPlayerName(string value)
        {
            playerName = value;
        }

        private void Form1_Load(object sender, EventArgs e) {
            SetPlayerName("???");
        }

    private void btnRulebook_Click(object sender, EventArgs e) {
     SoundPlayer click = new SoundPlayer(Resources.clack);
     click.Play();
     FrmRulebook rulebook = new FrmRulebook();
      rulebook.Show();
    }

    private void btnExitGame_Click(object sender, EventArgs e) {
      SoundPlayer click = new SoundPlayer(Resources.clack);
      click.Play();
      DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
      if (result == DialogResult.Yes)
        Application.Exit();
    }

    private void btnNewGame_Click(object sender, EventArgs e) {
      SoundPlayer click = new SoundPlayer(Resources.clack);
      click.Play();
      FrmNewGame frmNewGame = new FrmNewGame(GetPlayerName());
      frmNewGame.Show();
      this.Hide();
    }

    private void btnLeaderboard_Click(object sender, EventArgs e) {
      SoundPlayer click = new SoundPlayer(Resources.clack);
      click.Play();
      FrmLeaderboard leaderboard = new FrmLeaderboard();
      leaderboard.Show();
    }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
                SetPlayerName("???");
            else
                SetPlayerName(txtUserName.Text);
        }

    }
}