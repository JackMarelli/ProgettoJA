using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class player
    {

        string[] playlist = new string[3] {
            "Underwater_Indian_Guy_Meme.wav", 
            "levelup.wav",
            "Parmareggio_sara_perche_ti_amo_spot_pubblicita_2019_mp3cut.net.wav"
            };

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Underwater_Indian_Guy_Meme);
            simpleSound.Play();
        }

        public void playRandomSong()
        {
            //estraggo e riproduco canzone random
            Random rand = new Random();
            int num = rand.Next(3);
            MessageBox.Show(num.ToString());

            SoundPlayer simpleSound = new SoundPlayer(@"..\playlist\" + playlist[num]); //cambiare il percorso con assoluto
            simpleSound.Play();
        }
    }
}
