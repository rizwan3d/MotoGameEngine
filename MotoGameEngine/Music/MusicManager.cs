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
    public class MusicManager
    {
        private string _AudioFile;
        private ISoundOut soundOut;
        private IWaveSource soundSource;

        public bool PlayOnce;

        public string AudioFile {
            get
            {
                return _AudioFile;
            }
            set
            {
                _AudioFile = value;                
                
                soundSource = GetSoundSource();
                //Tell the SoundOut which sound it has to play
                soundOut?.Initialize(soundSource);
               
            }
        }
        public MusicManager()
        {
            //SoundOut implementation which plays the sound
            soundOut = GetSoundOut();
            soundOut.Stopped += SoundOut_Stopped;
            PlayOnce = true;
        }

        private void SoundOut_Stopped(object sender, PlaybackStoppedEventArgs e)
        {

            soundOut = GetSoundOut();
            //Tell the SoundOut which sound it has to play
            soundOut?.Initialize(soundSource);

            if (!PlayOnce)
            {
                soundOut?.Play();
            }
        }

        public void PlayMusic()
        {
            PlayOnce = false;
            soundOut?.Play();
        }

        public void PlaySFX()
        {
            PlayOnce = true;
            soundOut.Play();
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
            return CodecFactory.Instance.GetCodec(SDL_GetBasePath() +  _AudioFile);
        }

        public void PauseMusic()
        {
            soundOut?.Pause();
        }

        public void StopMusic()
        {
            PlayOnce = true;
            soundOut?.Stop();
        }
    }
    
}
