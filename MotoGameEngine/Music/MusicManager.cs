using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.SoundOut;
using static SDL2.SDL;
using System.Threading;
using CSCore.Codecs;

namespace MotoGameEngine
{
    public class MusicManager : IDisposable
    {
        private string _AudioFile;
        private ISoundOut soundOut;
        private IWaveSource soundSource;

        public bool PlayOnce = true;

        public string AudioFile {
            get
            {
                return _AudioFile;
            }
            set
            {
                _AudioFile = value;
                soundSource = GetSoundSource();
                //SoundOut implementation which plays the sound
                soundOut = GetSoundOut();

                //Tell the SoundOut which sound it has to play
                soundOut.Initialize(soundSource);
                soundOut.Stopped += SoundOut_Stopped;
            }
        }
        public MusicManager()
        {
            
        }

        private void SoundOut_Stopped(object sender, PlaybackStoppedEventArgs e)
        {
            if (soundOut != null)
            {
                if (soundOut.PlaybackState == PlaybackState.Stopped)
                {
                    soundSource = GetSoundSource();
                    //SoundOut implementation which plays the sound
                    soundOut = GetSoundOut();

                    //Tell the SoundOut which sound it has to play
                    soundOut.Initialize(soundSource);
                }
                if (!PlayOnce)
                {
                    PlayMusic();
                }
            }
        }

        public void PlayMusic()
        {
            if (soundOut != null)
            {
                PlayOnce = false;
                soundOut.Play();
            }
        }

        public void PlaySFX()
        {
            if (soundOut != null)
            {
                PlayOnce = true;
                soundOut.Play();
            }
        }

        private ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            else
                return new DirectSoundOut();
        }

        private IWaveSource GetSoundSource()
        {
            //return any source ... in this example, we'll just play a mp3 file
            return CodecFactory.Instance.GetCodec(SDL_GetBasePath() +  _AudioFile);
        }

        public void PauseMusic()
        {
            if(soundOut != null)
                soundOut.Pause();
        }

        public void StopMusic()
        {
            PlayOnce = true;
            if (soundOut != null)
                soundOut.Stop();
        }

        public void Dispose()
        {
            if (soundOut != null)
            {
                soundOut.Stopped -= SoundOut_Stopped;
                soundOut.Dispose();
                soundSource.Dispose();
            }
        }

        ~MusicManager()
        {
            Dispose();
        }
    }
    
}
