using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class player
    {
        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Underwater_Indian_Guy_Meme);
            simpleSound.Play();
        }

    }
    /*ciao mamma*/
}
