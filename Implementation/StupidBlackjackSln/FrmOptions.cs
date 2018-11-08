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

namespace StupidBlackjackSln
{
    public partial class FrmOptions: Form
    {
        public FrmOptions()
        {
            InitializeComponent();
			var principalForm = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();
			numericUpDown1.Value = principalForm.getVolume();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			SoundPlayer click = new SoundPlayer(Resources.clack);
			click.Play();
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int newvolume = (int)numericUpDown1.Value;
			var principalForm = Application.OpenForms.OfType<frmTitle>().FirstOrDefault();
			principalForm.changeVolume(newvolume);
		}
	}
}
