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

            const int FPS = 60;
            const int DELAY_TIME = 1000 / FPS;
            UInt32 frameStart, frameTime;

            Image img = new Image(w,@"\jk.png",100,100,200,200);  
            Sprite s = new Sprite(w, @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));           
            Sprite s2 = new Sprite(w, @"/sprite.bmp", 8, new Vector2D(500, 500), new Vector2D(32, 32));

            s.Flip(0, 0, 0, 1);
            s.Velocity = new Vector2D(1, 0);

            while (w.IsGameRunning)
            {
                frameStart = SDL_GetTicks();

                SDL_RenderClear(w._Renderer);                

                w.EventHandler();

                w.Render();

                if (s.Position.X > 800)
                {
                    s.Position.X = -64;
                }

                SDL_RenderPresent(w._Renderer);
                frameTime = SDL_GetTicks() - frameStart;
                if (frameTime < DELAY_TIME) { w.Delay(DELAY_TIME - frameTime); }

            }
        }
    }
}
