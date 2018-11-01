using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StupidBlackjackSln.Properties;

namespace StupidBlackjackSln
{
    public partial class FrmLose : Form
    {
        public FrmLose()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            FrmNewGame frmNewGame = new FrmNewGame();
            frmNewGame.Show();
            this.Hide();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            frmTitle frmTitle = new frmTitle();
            frmTitle.Show();
            this.Hide();
        }
    }
}
