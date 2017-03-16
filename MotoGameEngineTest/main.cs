using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDL2.SDL;
using static SDL2.SDL_image;
using MotoGameEngine;

namespace MotoGameEngineTest
{
    class main
    {
        public static void Main()
        {
            Window w = new Window("test", 800, 640);

            //Image img = new Image(w,@"\jk.png",100,100,200,200);

            //List<Image> img = new List<Image>();
            //int t = 0;
            //for(int i = 0; i < 800; i += 5)
            //{
            //    for (int j = 0; j < 640; j += 5)
            //    {
            //        img.Add(new Image(w, @"\wall2.png", i, j, 5, 5));
            //        t++;
            //    }
            //}
            //Console.Write(t);

            Sprite s = new Sprite(w, @"/foo.png", 0, 0, 64, 250);

            Sprite s2 = new Sprite(w, @"/sprite.bmp", 200, 200, 32, 32);


            while (w.IsGameRunning)
            {
                SDL_RenderClear(w._Renderer);
                
                w.EventHandler();
                s.Animate(1,4);
                s2.Animate(1, 8);
                //img.ForEach(i => { i.Render(); });

                SDL_RenderPresent(w._Renderer);

            }
        }
    }
}
