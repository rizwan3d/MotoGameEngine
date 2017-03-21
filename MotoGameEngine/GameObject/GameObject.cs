using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{ 
    public class GameObject 
    {
        public IntPtr _Renderer;
        public IntPtr _Texture; // the new SDL_Texture variable

        public Window _win;
        public Scene _S;

        public Vector2D Position { get; set; }
        public Vector2D Size { get; set; }

        public Vector2D Velocity { get; set; }
        public Vector2D Acceleration { get; set; }

        public bool Visible
        {
            get => visible;
            set => visible = value;
        }

        private bool visible = true;

        public GameObject(IntPtr Renderer)
        {
            Position = new Vector2D(0, 0); Size = new Vector2D(0, 0);
            _Renderer = Renderer;
        }
        public GameObject(IntPtr Renderer, int x, int y, int w, int h)
        {
            Position = new Vector2D(0, 0);
            Size = new Vector2D(0, 0);
            _Renderer = Renderer;
            Position.X = x;
            Position.Y = y;
            Size.X = h;
            Size.Y = w;
        }
        public GameObject(IntPtr Renderer, Vector2D position , Vector2D  size)
        {
            Position = new Vector2D(0, 0);
            Size = new Vector2D(0, 0);
            _Renderer = Renderer;
            Position = position;
            Size = size;
        }
        public virtual void Draw() {  }
        public virtual void Update() {  }

        public virtual void Clean() {  }
    }
}
