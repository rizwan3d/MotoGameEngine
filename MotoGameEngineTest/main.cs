using MotoGameEngine;

namespace MotoGameEngineTest
{
    class main
    {
        static Window w;

        //Animation need more work
        //Collision
        //GUI .Button,GUI Panal ,Lable etc
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

            Scene sc = new Scene("sc",w);
            Scene sc2 = new Scene("sc2",w);
            Scene grass = new Scene("grass", w);

            Image img = new Image(w, "sc", "img",@"\jk.png", new Vector2D(300, 300), new Vector2D(200, 200));
            Sprite s = new Sprite(w, "sc", "s", @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));
            Sprite s2 = new Sprite(w, "sc2", "s2", @"/sprite.bmp", 8, new Vector2D(300, 300), new Vector2D(32, 32));

            TileMap tm = new TileMap(w, "grass", @"\t\dirt.png", new Vector2D(40, 40), new Vector2D(0, 800), new Vector2D(550, 640));
            TileMap tm2 = new TileMap(w, "grass", @"\t\grass.png", new Vector2D(40, 44), new Vector2D(0, 840), new Vector2D(510, 550));
            
            img.Rotate(270);
            s.Flip(0, 0, 0, 1);
            s.Velocity = new Vector2D(1, 0);

            sc.OnSceneUpdate += Sc_OnSceneUpdate;
            sc2.OnSceneUpdate += Sc2_OnSceneUpdate;

            s.OnClicked += S_OnClicked;
            w.onEvent += W_onEvent;

            w.SceneManager.LoadScene("grass");
            w.SceneManager.LoadScene("sc2");
            w.SceneManager.LoadScene("sc");


            w.Start();
            
        }

        private static void Sc2_OnSceneUpdate(Scene sender)
        {
            sender.GetGameObject<Sprite>("s2").Animate();
        }

        private static void S_OnClicked(GameObject sender)
        {
            Debug.Log("----- Mouse Clicked on Me -----");
        }

        private static void Sc_OnSceneUpdate(Scene sender)
        {
            sender.GetGameObject<Sprite>("s").Animate();   

            if (sender.GetGameObject<Sprite>("s").Position.X == 800 - 65)
            {
                sender.GetGameObject<Sprite>("s").Velocity = new Vector2D(-1, 0);
                sender.GetGameObject<Sprite>("s").Flip(0, 0, 0, 0);
            }
            if (sender.GetGameObject<Sprite>("s").Position.X == 0)
            {
                sender.GetGameObject<Sprite>("s").Velocity = new Vector2D(1, 0);
                sender.GetGameObject<Sprite>("s").Flip(0, 0, 0, 1);
            }
        }

        private static void W_onEvent(Window sender, Event e)
        {
            if (sender.IsKeyPresed(KeyCode.d))
            {
                sender.SceneManager.GetGameObject<Sprite>("sc2","s2").Position.X += 1;
            }
            if (sender.IsKeyPresed(KeyCode.a))
            {
                sender.SceneManager.GetGameObject<Sprite>("sc2", "s2").Position.X -= 1;
            }
            if (sender.IsKeyPresed(KeyCode.w))
            {
                sender.SceneManager.GetGameObject<Sprite>("sc2", "s2").Position.Y -= 1;
            }
            if (sender.IsKeyPresed(KeyCode.s))
            {
                sender.SceneManager.GetGameObject<Sprite>("sc2", "s2").Position.Y += 1;
            }
            if (sender.IsKeyPresed(KeyCode.t))
            {
                Image kk = new Image(w,"sc2", "kk", @"\wall2.png", new Vector2D(1, 1), new Vector2D(200, 200), true);
            }
            if (sender.IsKeyPresed(KeyCode.y))
            {
                sender.SceneManager.GetScene("sc2").Destroy("kk");
            }
        }
    }
}