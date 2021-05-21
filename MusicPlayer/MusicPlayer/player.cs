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
        SoundPlayer p = new SoundPlayer();
        string[] playlist = new string[3] {
            "Underwater_Indian_Guy_Meme.wav",
            "levelup.wav",
            "Parmareggio_sara_perche_ti_amo_spot_pubblicita_2019_mp3cut.net.wav"
            };
        string current;

        public player()
        {

            //porta = new SerialPort("COM", 9600);
            //porta.Open();
            //porta.DataReceived += porta_DataReceived;
            current = "";
        }

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Underwater_Indian_Guy_Meme);
            simpleSound.Play();
        }

        public void playRandomSong()
        {
                //estraggo e riproduco canzone random
                Random rand = new Random(); //numero random
                int num = rand.Next(3);
                current = playlist[num];
                string songpath = (Directory.GetCurrentDirectory() + @"\..\..\playlist\" + current);
                MessageBox.Show("Canzone in posizione: " + num.ToString() + " \nPath: "  + songpath);
                SoundPlayer randsong = new SoundPlayer(songpath); //cambiare il percorso con assoluto
                randsong.Play();
        }

        public void changeSong()
        {
            //estraggo e riproduco canzone random SE non è uguale a quella che sta già riproducendo
            Random rand = new Random(); //numero random
            int num = rand.Next(3);

            while (playlist[num] == current) { //controllo se non è uguale a quella che sta già riproducendo
                int newnum = rand.Next(3); 
            }

            string songpath = (Directory.GetCurrentDirectory() + @"\..\..\playlist\" + current);
            MessageBox.Show("Canzone in posizione: " + num.ToString() + " \nPath: " + songpath);
            SoundPlayer randsong = new SoundPlayer(songpath);
            randsong.Play();

        }

        public void porta_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //LEGGO COSA C'E' NEL BUFFER
            string lettura = porta.ReadExisting();
            if (lettura == "P")
            {
                playRandomSong();
            }
            else if (lettura == "p")
            {
                //interrompo riproduzione
                p.Stop();
            }
            else if (lettura == "c"){
                //cambio canzone
                changeSong();
            }
            // ... altre funzioni ...
        }


    }
}
