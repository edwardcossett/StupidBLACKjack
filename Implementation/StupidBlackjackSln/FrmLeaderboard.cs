using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBlackjackSln
{
    public partial class FrmLeaderboard : Form
    {
        public FrmLeaderboard()
        {
            InitializeComponent();
        }

        private void FrmLeaderboard_Load(object sender, EventArgs e)
        {
            if (!File.Exists("..\\..\\Resources\\input.txt"))
                File.CreateText("..\\..\\Resources\\input.txt");
            using (StreamReader input = File.OpenText("..\\..\\Resources\\input.txt"))
            {
                string line;
                string[] lineParts = new string[2];
                List<int> streaks = new List<int>();
                List<String> names = new List<string>();
                int tempStreak;
                int counter = 0;
                int maxStreak = 0;
                int maxIndex = 0;
                while (null != (line = input.ReadLine()))
                {
                    lineParts = line.Split(':');
                    names.Add(lineParts[0]);
                    int.TryParse(lineParts[1], out tempStreak);
                    streaks.Add(tempStreak);
                    counter++;
                }
                if (counter > 0)
                    for (int i = 0; i <= 4; i++)
                    {
                        if (streaks.Count == 0)
                            break;
                        //find largest streak per iter. Ties won by earliest entry
                        counter = 0;
                        maxIndex = 0;
                        maxStreak = 0;
                        foreach (int streak in streaks)
                        {
                            if (streak > maxStreak)
                            {
                                maxStreak = streak;
                                maxIndex = counter;
                            }
                            counter++;
                        }
                        //set max streak associated name to position i
                        switch (i)
                        {
                            case 0:
                                lblName1.Text = names.ElementAt(maxIndex);
                                lblStreak1.Text = streaks.ElementAt(maxIndex).ToString();
                                break;
                            case 1:
                                lblName2.Text = names.ElementAt(maxIndex);
                                lblStreak2.Text = streaks.ElementAt(maxIndex).ToString();
                                break;
                            case 2:
                                lblName3.Text = names.ElementAt(maxIndex);
                                lblStreak3.Text = streaks.ElementAt(maxIndex).ToString();
                                break;
                            case 3:
                                lblName4.Text = names.ElementAt(maxIndex);
                                lblStreak4.Text = streaks.ElementAt(maxIndex).ToString();
                                break;
                            case 4:
                                lblName5.Text = names.ElementAt(maxIndex);
                                lblStreak5.Text = streaks.ElementAt(maxIndex).ToString();
                                break;
                        }
                        names.RemoveAt(maxIndex);
                        streaks.RemoveAt(maxIndex);
                    }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
