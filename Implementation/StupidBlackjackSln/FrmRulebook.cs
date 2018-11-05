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
using StupidBlackjackSln.Properties;

namespace StupidBlackjackSln {
  public partial class FrmRulebook : Form {
    public FrmRulebook() {
      InitializeComponent();
    }

    private void btnCloseWindow_Click(object sender, EventArgs e) {
     SoundPlayer click = new SoundPlayer(Resources.clack);
     click.Play();
     Close();
    }
  }
}
