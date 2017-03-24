using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class TileMap
    {
        public TileMap(Window win,string SceneName,string Path,Vector2D Size,Vector2D StartPostion,Vector2D EndPoint)
        {
            for (int i = (int)StartPostion.X; i < StartPostion.Y; i += (int)Size.X)
            {
                for (int j = (int)EndPoint.X; j < EndPoint.Y; j += (int)Size.Y)
                {
                    Image img2 = new Image(win, SceneName, SceneName + Path + i + j + Random.Get(StartPostion.X, StartPostion.Y), Path, new Vector2D(i, j), Size);
                }
            }
        }
    }
}
