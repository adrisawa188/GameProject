using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameProject
{
    public partial class arcadeGame : Form
    {
        public arcadeGame()
        {
            InitializeComponent();
        }

        private void arcadeGame_Load(object sender, EventArgs e)
        {

        }



        private void startButton_Click(object sender, EventArgs e)
        {
            //give feedback for pressing the start button 
            SoundPlayer startBeepPlayer = new SoundPlayer(Properties.Resources.startBeep);
            startBeepPlayer.Play();
            this.startButton.Visible = false;
            Refresh();
            Thread.Sleep(1000);

            //countdown to 1 with "game starting" notice and beep
            SoundPlayer beepPlayer = new SoundPlayer(Properties.Resources.Beep__2_);
            outputText.Text = "game starting in:";
            countdown.Text = "3";
            beepPlayer.Play();
            Refresh();
            Thread.Sleep(1000);
            countdown.Text = "2";
            beepPlayer.Play();
            Refresh();
            Thread.Sleep(1000);
            countdown.Text = "1";
            beepPlayer.Play();
            Refresh();
            Thread.Sleep(1000);

            //remove countdown
            this.countdown.Visible = false;

            //change background colour and display go
            SoundPlayer gameStartPlayer = new SoundPlayer(Properties.Resources.game_start);
            gameStartPlayer.Play();
            BackColor = Color.Green;
            outputText.BackColor = Color.Green;
            outputText.Text = "GO!";









        }
    }
}


