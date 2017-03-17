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
        static Window w;

        static Image img;
        static Sprite s;
        static Sprite s2;

        public static void Main()
        {
            w = new Window("test", new Vector2D(800, 640));

            img = new Image(w,@"\jk.png", new Vector2D(300, 300), new Vector2D(200, 200));
            s = new Sprite(w, @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));
            s2= new Sprite(w, @"/sprite.bmp", 8, new Vector2D(500, 500), new Vector2D(32, 32));

            img.Rotate(90);
            s.Flip(0, 0, 0, 1);
            s.Velocity = new Vector2D(1, 0);

            w.Update += W_Update;
            w.onEvent += W_onEvent;
            w.Start();

        }

        private static void W_onEvent(Window sender, Event e)
        {
            if (e == Event.QUIT)
                w.IsGameRunning = false;
            Console.WriteLine($"{sender.MousePositionX} , {sender.MousePositionY}");
            if (sender.IsKeyPresed(KeyCode.d))
            {
                s2.Position.X += 1;
            }
            if (sender.IsKeyPresed(KeyCode.a))
            {
                s2.Position.X -= 1;
            }
            if (sender.IsKeyPresed(KeyCode.w))
            {
                s2.Position.Y -= 1;
            }
            if (sender.IsKeyPresed(KeyCode.s))
            {
                s2.Position.Y += 1;
            }
        }

        private static void W_Update(Window sender)
        {
            if (s.Position.X > 800)
            {
                s.Position.X = -64;
            }
        }
    }
}
