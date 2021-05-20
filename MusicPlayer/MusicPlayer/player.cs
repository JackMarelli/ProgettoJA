using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml.Linq;

namespace MusicPlayer
{
    public class player
    {
        SerialPort porta;
        string[] playlist = new string[3] {
            "Underwater_Indian_Guy_Meme.wav",
            "levelup.wav",
            "Parmareggio_sara_perche_ti_amo_spot_pubblicita_2019_mp3cut.net.wav"
            };

        public player()
        {
            //porta = new SerialPort("COM", 9600);
            //porta.Open();
            //porta.DataReceived += porta_DataReceived;
        }

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Underwater_Indian_Guy_Meme);
            simpleSound.Play();
        }

        public void playRandomSong(TextBox t)
        {
                //estraggo e riproduco canzone random
                Random rand = new Random();
                int num = rand.Next(3);
                MessageBox.Show(num.ToString());
                
                string songpath = Directory.GetCurrentDirectory() + @"\..\..\playlist\" + playlist[num];
                MessageBox.Show(songpath);
                t.Text = songpath;
                SoundPlayer randsong = new SoundPlayer(songpath); //cambiare il percorso con assoluto
                //randsong.Play();
        }

        public void porta_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //LEGGO COSA C'E' NEL BUFFER
            string lettura = porta.ReadExisting();
            if (lettura == "P")
            {
                //playRandomSong();
            }
            else if (lettura == "p")
            {
                //interrompo riproduzione
            }
            /*else if (lettura == "")
            {
                aggiungere poi if che implementano altre funzioni
            }*/
        }


    }
}
