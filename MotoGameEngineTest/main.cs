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
            Window w = new Window("test", new Vector2D(800, 640));

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


            //List<Sprite> s = new List<Sprite>();
            //int t = 0;
            //for (int i = 0; i < 800; i += 32)
            //{
            //    for (int j = 0; j < 640; j += 32)
            //    {
            //        Sprite p = new Sprite(w, @"/sprite.bmp", i, j, 32, 32);
            //        p.Rotate(45);
            //        s.Add(p);
            //        t++;
            //    }
            //}
            //Console.Write(t);

            //SpriteManager sm = new SpriteManager();
            //int t = 0;
            //for (int i = 0; i < 800; i += 32)
            //{
            //    for (int j = 0; j < 640; j += 32)
            //    {
            //        sm.Add(new Sprite(w, @"/sprite.bmp", 8, i, j, 32, 32));
            //        t++;
            //    }
            //}
            //Console.Write(t);


            Sprite s = new Sprite(w, @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));
            s.Flip(0,0,0,1);
            s.Velocity = new Vector2D(1, 0);
            //Sprite s2 = new Sprite(w, @"/sprite.bmp", 200, 200, 32, 32);

            //Vector2D v1 = new Vector2D(2, 3);
            //Vector2D v2 = new Vector2D(2, 3);
            //Vector2D v3 = new Vector2D(2, 3);
            //Vector2D v4 = v1 + v2 + v3;

            //Console.WriteLine(v4.X + " , " + v4.Y);
            const int FPS = 60;
            const int DELAY_TIME = 1000 / FPS;
            UInt32 frameStart, frameTime;

            while (w.IsGameRunning)
            {
                frameStart = SDL_GetTicks();

                SDL_RenderClear(w._Renderer);                

                w.EventHandler();
                s.Update();
                s.Animate();
                //s.Animate();
                //s2.Animate(1, 8);

                //s.ForEach(i => { i.Animate(1,8); });

                //sm.Animate();

                SDL_RenderPresent(w._Renderer);
                frameTime = SDL_GetTicks() - frameStart;
                if (frameTime < DELAY_TIME) { w.Delay(DELAY_TIME - frameTime); }

            }
        }
    }
}
