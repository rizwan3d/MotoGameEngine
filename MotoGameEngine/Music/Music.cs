using NAudio.Wave;

namespace MotoGameEngine
{
    public class Music
    {
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        public string _Name;

        bool _Looped;

        public Music(string Path,string Name,bool looped = false)
        {
            waveOutDevice = new WaveOut();
            _Looped = looped;
            waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;
            _Name = Name;
            
            audioFileReader = new AudioFileReader(Path);
            waveOutDevice.Init(audioFileReader);
        }

        private void WaveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (_Looped)
            {
                if (audioFileReader != null)
                {
                    audioFileReader.Position = 0;
                    Play();
                }
            }
        }

        public void Play()
        {
            waveOutDevice.Play();
        }

        public void CloseWaveOut()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }

        public void Pause()
        {
            waveOutDevice.Stop();
        }

        public void Stop()
        {
            waveOutDevice.Stop();
            audioFileReader.Position = 0;
        }
    }
}
