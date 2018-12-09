using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Hafta3Gun5Part3
{
    public partial class AlarmForm : Form
    {
        public string Description { get; set; }
        public Form1 PrevForm { get; set; }
        private SoundPlayer soundPlayer;
        private int counter = 0;
        private const string imagePath = @"D:\Ayvansaray Uni Projects\Ayvansaray-Uni-Projects\Sezgin\Hafta3\Hafta3Gun5\";
        private const string soundPath = @"D:\Ayvansaray Uni Projects\Ayvansaray-Uni-Projects\Sezgin\Hafta3\Hafta3Gun5\eagle.wav";

        public AlarmForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            soundPlayer.Stop();
            this.Dispose();
            PrevForm.initializeVars();
            PrevForm.Show();
        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            tbDescription.Text = Description;
            soundPlayer = new System.Media.SoundPlayer(soundPath);
            ringAlarm();
            timer1.Start();
        }

        private void ringAlarm()
        {
            soundPlayer.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter % 2 == 0)
            {
                tbDescription.BackColor = Color.White;
                tbDescription.ForeColor = Color.Black;
                pbImage.ImageLocation = imagePath + "alarm-1.png";
            }
            else
            {
                tbDescription.BackColor = Color.Red;
                tbDescription.ForeColor = Color.White;
                pbImage.ImageLocation = imagePath + "alarm-2.png";
            }

            counter++;
        }
    }
}
