using MotoGameEngine;

namespace MotoGameEngineTest
{
    class main
    {
        static Window w;

        static Scene sc;
        static Scene sc2;

        //Animation need more work
        //Collision
        //GUI .Button,GUI Panal ,Lable etc
        //Tilemaps
        //Partical System
        //movie files
        //camera system
        //Event System need more events
        //load data(image,sprite,animation,tilemap,movie etc) form XML
        //Visual editor
        //
        //Additional
        //
        //Rigidbody
        //path finding
        //AI agents
        //Networking


        public static void Main()
        {
            w = new Window("test", new Vector2D(800, 640));

            sc = new Scene(w);
            sc2 = new Scene(w);

            Image img = new Image(sc,"img",@"\jk.png", new Vector2D(300, 300), new Vector2D(200, 200));
            Sprite s = new Sprite(sc, "s", @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));
            Sprite s2 = new Sprite(sc2, "s2", @"/sprite.bmp", 8, new Vector2D(500, 500), new Vector2D(32, 32));
            
            GameObject g = new GameObject(w._Renderer);
            sc.Add(g);

            sc.OnSceneUpdate += Sc_OnSceneUpdate;

            w.SceneManager.Add(sc);
            w.SceneManager.Add(sc2);

            //w.MusicManager.Add(@"a.wav","a",true);
            //w.MusicManager.Add(@"b.wav", "b");
            //w.MusicManager.Add(@"c.wav", "c");
            //w.MusicManager.Add(@"d.mp3", "d");

            //w.MusicManager.Play("a");
            //w.MusicManager.Play("b");
            //w.MusicManager.Play("c");
            //w.MusicManager.Play("d");

            img.Rotate(270);
            s.Flip(0, 0, 0, 1);
            s.Velocity = new Vector2D(1, 0);
                      
            w.onEvent += W_onEvent;

            w.SceneManager.LoadScene(sc2);
            w.SceneManager.LoadScene(sc);

            s.OnClicked += S_OnClicked;

            w.Start();
            
        }

        private static void S_OnClicked(GameObject sender)
        {
            Debug.Log("----- Mouse Clicked on Me -----");
        }

        private static void Sc_OnSceneUpdate(Scene sender)
        {
            sc.GetGameObject<Sprite>("s").Animate();
            sc2.GetGameObject<Sprite>("s2").Animate();

            if (sc.GetGameObject<Sprite>("s").Position.X == 800 - 65)
            {
                sc.GetGameObject<Sprite>("s").Velocity = new Vector2D(-1, 0);
                sc.GetGameObject<Sprite>("s").Flip(0, 0, 0, 0);
            }
            if (sc.GetGameObject<Sprite>("s").Position.X == 0)
            {
                sc.GetGameObject<Sprite>("s").Velocity = new Vector2D(1, 0);
                sc.GetGameObject<Sprite>("s").Flip(0, 0, 0, 1);
            }
        }

        private static void W_onEvent(Window sender, Event e)
        {
            if (sender.IsKeyPresed(KeyCode.d))
            {
                sc2.GetGameObject<Sprite>("s2").Position.X += 1;
            }
            if (sender.IsKeyPresed(KeyCode.a))
            {
                sc2.GetGameObject<Sprite>("s2").Position.X -= 1;
            }
            if (sender.IsKeyPresed(KeyCode.w))
            {
                sc2.GetGameObject<Sprite>("s2").Position.Y -= 1;
            }
            if (sender.IsKeyPresed(KeyCode.s))
            {
                sc2.GetGameObject<Sprite>("s2").Position.Y += 1;
            }
            if (sender.IsKeyPresed(KeyCode.t))
            {
                Image kk = new Image(sc2, "kk", @"\wall2.png", new Vector2D(1, 1), new Vector2D(200, 200), true);
            }
            if (sender.IsKeyPresed(KeyCode.y))
            {
                sc2.Destroy("kk");
            }
        }
    }
}