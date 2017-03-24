using MotoGameEngine;

namespace MotoGameEngineTest
{
    class Program    {
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
            w = new Window("test", new Vector2D(800, 640))
            {
                FPS = 60
            };
            Scene sc = new Scene("sc",w);
            Scene sc2 = new Scene("sc2",w);
            Scene grass = new Scene("grass", w);

            Image img = new Image(w, "sc", "img",@"\jk.png", new Vector2D(300, 300), new Vector2D(200, 200));
            Sprite s = new Sprite(w, "sc", "s", @"/foo.png", 4 , new Vector2D(0,0) , new Vector2D(64,250));
            Sprite s2 = new Sprite(w, "sc2", "s2", @"/sprite.bmp", 8, new Vector2D(300, 300), new Vector2D(32, 32));

            TileMap tm = new TileMap(w, "grass", @"\t\dirt.png", new Vector2D(40, 40), new Vector2D(0, 800), new Vector2D(550, 640));
            TileMap tm2 = new TileMap(w, "grass", @"\t\grass.png", new Vector2D(40, 44), new Vector2D(0, 840), new Vector2D(510, 550));

            w.SceneManager.GetGameObject<Image>("sc", "img").Rotate(270);
            w.SceneManager.GetGameObject<Sprite>("sc", "s").Flip(0, 0, 0, 1);
            w.SceneManager.GetGameObject<Sprite>("sc", "s").Velocity = new Vector2D(1, 0);

            
            w.SceneManager.LoadScene("grass");
            w.SceneManager.LoadScene("sc2");
            w.SceneManager.LoadScene("sc");

            Events e = new Events(w);

            w.Start();
            
        }
    }
}