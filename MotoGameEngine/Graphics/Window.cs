using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;
using static SDL2.SDL;  // add SDL class form namespace SDL2

namespace MotoGameEngine
{
    public class Window : IDisposable
    {
        public IntPtr _Window;  // pointer for SDL window
        public IntPtr _Renderer;

        private string _Title;
        private int _W, _H;
        private bool _isFullScreen;

        private SDL_WindowFlags Flag;

        public bool IsGameRunning;
  
        SDL_Event _event;

        int _FPS;
        uint DELAY_TIME;
        public int FPS { get => _FPS; set { _FPS = value; DELAY_TIME = (uint)(1000 / _FPS); } }
        
        UInt32 frameStart, frameTime;

        private SceneManager _SceneManager = new SceneManager();
        public SceneManager SceneManager { get => _SceneManager; set => _SceneManager = value; }

        public event EventUpdatedelegate onEvent;
        public event Updatedelegate Update;

        public Window(string Title, int W, int H, bool isFullScreen = false)
        {
            IsGameRunning = false;
            _Title = Title;
            _W = W;
            _H = H;
            _isFullScreen = isFullScreen;
            if (!Init())
            {
                throw (new Initializing("Error occurred initializing"));
            }
            //UPDATELOOP();
        }
        public Window(string Title, Vector2D size, bool isFullScreen = false)
        {
            IsGameRunning = false;
            _Title = Title;
            _W = (int)size.X;
            _H = (int)size.Y;
            _isFullScreen = isFullScreen;
            if (!Init())
            {
                throw (new Initializing("Error occurred initializing"));
            }
          
        }

        bool Init()
        {

            if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) < 0)
                throw (new Initializing_SDL("Error occurred initializing SDL"));

            Flag = SDL_WindowFlags.SDL_WINDOW_SHOWN;

            if (_isFullScreen)
            {
                Flag |= SDL_WindowFlags.SDL_WINDOW_FULLSCREEN;
            }
            // if succeeded create our window    
            _Window = SDL_CreateWindow(_Title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, _W, _H, Flag);
            // if the window creation succeeded create our renderer    
            if (_Window == null || _Window == IntPtr.Zero)
            {
                throw (new Initializing_Window("Error occurred initializing Window"));
            }
            _Renderer = SDL_CreateRenderer(_Window, -1, SDL_RendererFlags.SDL_RENDERER_ACCELERATED);

            // everything succeeded lets draw the window
            // set to black 
            //This function expects Red, Green, Blue and   
            //  Alpha as color values  
            SDL_SetRenderDrawColor(_Renderer, 039, 058, 093, 255);

            FPS = 60;

            IsGameRunning = true;
            
            return true;
        }

        public void Delay(uint Time)
        {
            SDL_Delay(Time);
        }

        public void Dispose()
        {
            SDL_DestroyWindow(_Window);
            SDL_DestroyRenderer(_Renderer);
            _Window = IntPtr.Zero;
            SDL_Quit();
            Environment.Exit(0);
        }      
        ~Window()
        {
            Dispose();
        }

        public void Render() {
            frameStart = SDL_GetTicks();
            // clear the window to black  
            SDL_RenderClear(_Renderer);
            
            Update?.Invoke(this);
            // show the window    
            _SceneManager.Update();
            SDL_RenderPresent(_Renderer);

            frameTime = SDL_GetTicks() - frameStart;
            if (frameTime < DELAY_TIME) { Delay(DELAY_TIME - frameTime); }
        }
        //public void EventHandler() {
        //    if (SDL_PollEvent(out _event) == 1)
        //    {
        //        switch (_event.type)
        //        {
        //            case SDL_EventType.SDL_QUIT:
        //                IsGameRunning = false;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
       
        #region Input

        //create a instance of InputInit 
        InputInit II = new InputInit();

        public bool IsKeyPresed(KeyCode keycode)
        {
            // if event is related to key down
            if (_event.type == SDL_EventType.SDL_KEYDOWN)
                // return true if event key is same as input key
                if (_event.key.keysym.sym == II.kecodefinder[keycode])
                    return true;
            // same as up but if key up and return false
            if (_event.type == SDL_EventType.SDL_KEYUP)
                if (_event.key.keysym.sym == II.kecodefinder[keycode])
                    return false;
            return false;
        }

        public bool IsMouseButtonPressed(MouseButton code)
        {
            // if event related to mouse button doen
            if (_event.type == SDL_EventType.SDL_MOUSEBUTTONDOWN)
            {
                // button is Right and return true
                if (code == MouseButton.RIGHT)
                {
                    if (_event.button.button == SDL_BUTTON_RIGHT)
                        return true;
                }
                // same as up but for left
                else if (code == MouseButton.LEFT)
                {
                    if (_event.button.button == SDL_BUTTON_LEFT)
                        return true;
                }
            }
            // same up but return false if event is relater to button up
            if (_event.type == SDL_EventType.SDL_MOUSEBUTTONUP)
            {
                if (code == MouseButton.RIGHT)
                {
                    if (_event.button.button == SDL_BUTTON_RIGHT)
                        return false;
                }
                else if (code == MouseButton.LEFT)
                {
                    if (_event.button.button == SDL_BUTTON_LEFT)
                        return false;
                }
            }
            return false;
        }

        // var to store mouse positions
        int x, y;

        public int MousePositionX
        {
            get
            {
                // get postion and store to x and y
                SDL_GetMouseState(out x, out y);
                //return x postion
                return x;
            }
        }

        public int MousePositionY
        {
            get
            {
                // get postion and store to x and y
                SDL_GetMouseState(out x, out y);
                //return x postion
                return y;
            }
        }
        
        #endregion
        #region Event and Updates

        eventInit ei = new eventInit();

        // call Funtion on event and without event update
        public void Start(/*Func<Event, int> EventUpdateFunction,Action Update*/)
        {
            // if window is open
            while (IsGameRunning)
            {
                /* Check for new events */
                if (SDL_PollEvent(out _event) == 1)
                {
                    //if event is related to Window
                    //if (_event.type == SDL_EventType.SDL_WINDOWEVENT)
                    //    //if Window resized call  resetSize()
                    //    if (_event.window.windowEvent == SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED)
                    //        resetSize();
                    // call give function on new event
                    Event e = ei.eventfinder[_event.type];
                    //ventUpdateFunction(e);                             
                   onEvent?.Invoke(this, e);
                }                
                Render();               
            }
        }
        #endregion
    }
}
