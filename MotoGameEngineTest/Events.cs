using MotoGameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngineTest
{
    class Events
    {
        Window w;
        public Events(Window win)
        {
            w = win;
            AddEvents();
        }

        void AddEvents()
        {
            w.SceneManager.GetScene("sc").OnSceneUpdate += Sc_OnSceneUpdate;
            w.SceneManager.GetScene("sc2").OnSceneUpdate += Sc2_OnSceneUpdate;

            w.SceneManager.GetGameObject<Sprite>("sc", "s").OnClicked += S_OnClicked;
            w.OnEvent += W_onEvent;
        }

        void Sc2_OnSceneUpdate(Scene sender)
        {
            sender.GetGameObject<Sprite>("s2").Animate();
        }

        void S_OnClicked(GameObject sender)
        {
            Debug.Log("----- Mouse Clicked on Me -----");
        }

        void Sc_OnSceneUpdate(Scene sender)
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
            w.SceneManager.GetGameObject<Sprite>("sc2", "s2").Position.X = w.MousePositionX + 15;
            w.SceneManager.GetGameObject<Sprite>("sc2", "s2").Position.Y = w.MousePositionY + 15;
            if (sender.GetGameObject<Sprite>("s").IsColliding(w.SceneManager.GetGameObject<Sprite>("sc2", "s2")))
                Debug.Error("Inside");
        }

        void W_onEvent(Window sender, Event e)
        {
            if (sender.IsKeyPresed(KeyCode.d))
            {
                sender.SceneManager.GetGameObject<Sprite>("sc2", "s2").Position.X += 1;
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
                Image kk = new Image(w, "sc2", "kk", @"\wall2.png", new Vector2D(1, 1), new Vector2D(200, 200), true);
            }
            if (sender.IsKeyPresed(KeyCode.y))
            {
                sender.SceneManager.GetScene("sc2").Destroy("kk");
            }
            if (sender.IsKeyPresed(KeyCode.r))
            {
                sender.SceneManager.GetGameObject<Image>("sc", "img").SetImage(@"/a.bmp");
            }
            if (sender.IsKeyPresed(KeyCode.e))
            {
                sender.SceneManager.GetGameObject<Image>("sc", "img").SetImage(@"/jk.png");
            }
            if (sender.IsKeyPresed(KeyCode.c))
            {
                Console.Clear();
            }
        }
    }
}
