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

namespace StupidBlackjackSln
{
    public partial class FrmOptions: Form
    {
		WindowsMediaPlayer click = new WindowsMediaPlayer();

		public FrmOptions()
        {
            InitializeComponent();

			click.settings.autoStart = false;
			click.URL = "clack.wav";

			var principalForm = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();
			numericUpDown1.Value = principalForm.getVolume();
			numericUpDown2.Value = principalForm.getEffectsVolume();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			click.controls.play();
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			click.controls.play();
			int newvolume = (int)numericUpDown1.Value;
			var principalForm = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();
			principalForm.changeVolume(newvolume);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int effectvolume = (int)numericUpDown2.Value;
			click.settings.volume = effectvolume;
			click.controls.play();

			var titleForm  = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();

			titleForm.changeEffectsVolume(effectvolume);
		}
	}
}
