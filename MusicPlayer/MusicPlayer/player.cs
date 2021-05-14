using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Xml.Linq;

namespace MusicPlayer
{
    public class player
    {
        SerialPort porta;
        player()
        {
            porta = new SerialPort("COM", 9600);
            porta.Open();
            porta.DataReceived += porta_DataReceived;
        }

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Underwater_Indian_Guy_Meme);
            simpleSound.Play();
        }

        public void playRandomSong()
        {
            //scelgo e riproduco canzone random
        }

        private void porta_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //LEGGO COSA C'E' NEL BUFFER
            string lettura = porta.ReadExisting();
            if (lettura == "P")
            {
                //faccio partire canzone casuale
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
