using MotoGameEngine;

namespace MotoGameEngineTest
{
    class main
    {
        static Window w;

        static Image img;
        static Sprite s;
        static Sprite s2;
        static Scene sc;
        static Scene sc2;

        public static void Main()
        {
            w = new Window("test", new Vector2D(800, 640));

            sc = new Scene(w);
            sc2 = new Scene(w);

            img = new Image(sc,@"\jk.png", new Vector2D(300, 300), new Vector2D(200, 200));
            s = new Sprite(sc, @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));
            s2= new Sprite(sc2, @"/sprite.bmp", 8, new Vector2D(500, 500), new Vector2D(32, 32));

            sc.OnSceneUpdate += Sc_OnSceneUpdate;

            w.SceneManager.Add(sc);

            w.SceneManager.Add(sc2);

            img.MusicManager.AudioFile = @"./a.mp3";
            s.MusicManager.AudioFile = @"./b.mp3";
            s.MusicManager.PlayMusic();
            img.MusicManager.PlayMusic();
            s.Visible = true;

            img.Rotate(270);
            s.Flip(0, 0, 0, 1);
            s.Velocity = new Vector2D(1, 0);
       
           
            w.Update += W_Update;
            w.onEvent += W_onEvent;
            w.OnExit += W_OnExit;
            w.Start();

        }

        private static void W_OnExit(Window sender)
        {
           
        }

        private static void Sc_OnSceneUpdate(Scene sender)
        {
            s.Animate();
            s2.Animate();
            if (s.Position.X == 800 - 65)
            {
                s.Velocity = new Vector2D(-1, 0);
                s.Flip(0, 0, 0, 0);
            }
            if (s.Position.X == 0)
            {
                s.Velocity = new Vector2D(1, 0);
                s.Flip(0, 0, 0, 1);
            }
        }

        private static void W_onEvent(Window sender, Event e)
        {
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
            if (sender.IsKeyPresed(KeyCode.t))
                sender.SceneManager.LoadScene(sc2);
            if (sender.IsKeyPresed(KeyCode.y))
                sender.SceneManager.UnLoad(sc2);
        }

        private static void W_Update(Window sender)
        {
            w.SceneManager.LoadEverything();
        }
    }
}