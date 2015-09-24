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

namespace Sound_Naidis
{
    public partial class Form1 : Form
    {
        SoundPlayer simpleSound;
        string melody1 = "Content/322856__visionspace__123454.wav";
        string melody2 = "Content/322363__mit847__creepy.wav";
        string melody3 = "Content/322358__gadziller__witch.mp3";
        string melody4 = "Content/drum.mp3";
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            
            wplayer.URL = melody3;
            wplayer.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simpleSound = new SoundPlayer(melody1);
            simpleSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //simpleSound = new SoundPlayer(melody2);
            //simpleSound.PlayLooping();
            wplayer.URL = melody4;
            wplayer.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wplayer.controls.fastForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wplayer.controls.fastReverse();
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Left)
            {
                wplayer.controls.fastForward();
            } 
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Right)
            {
                wplayer.controls.fastReverse();
            }
            
        }
    }
}
