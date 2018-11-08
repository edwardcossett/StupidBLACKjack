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
using WMPLib;

namespace StupidBlackjackSln {
  public partial class FrmRulebook : Form {
		WindowsMediaPlayer click = new WindowsMediaPlayer();
		public FrmRulebook() {
			click.settings.autoStart = false;
			click.URL = "clack.wav";
			InitializeComponent();
    }

    private void btnCloseWindow_Click(object sender, EventArgs e) {
	 changeEffectsVolume();
     click.controls.play();
     Close();
    }
		private void changeEffectsVolume()
		{
			var principalForm = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();
			click.settings.volume = principalForm.getEffectsVolume();
		}
	}
}
