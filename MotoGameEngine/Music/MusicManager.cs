using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static SDL2.SDL;


namespace MotoGameEngine
{
    public class MusicManager
    {
        List<Music> _List;

        public MusicManager()
        {
            _List = new List<Music>();           
        }

        public void Add(string path, string Name , bool looped = false)
        {
            _List.Add(new Music(path, Name, looped));
        }

        public void Play(string Name)
        {
            _List.ForEach(
                m =>
                {
                    if (m._Name == Name)
                        m.Play();
                });
        }

        public void Stop(string Name)
        {
            _List.ForEach(
                m =>
                {
                    if (m._Name == Name)
                        m.Stop();
                });
        }
    }    
}