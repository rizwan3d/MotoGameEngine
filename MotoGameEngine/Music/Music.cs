using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class Music
    {
        SoundPlayer sp;

        public string _Name;

        bool _Looped;

        public Music(string Path,string Name,bool looped = false)
        {
            _Looped = looped;
            _Name = Name;
            sp = new SoundPlayer(Path);
        }

        public void Play()
        {
            if (_Looped)
                sp.PlayLooping();
            else
                sp.Play();
        }
        public void Stop()
        {
            sp.Stop();
        }
    }
}
