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
        public Window(string Title, int W, int H, bool isFullScreen = false)
        {
            IsGameRunning = false;
            _Title = Title;
            _W = W;
            _H = H;
            _isFullScreen = isFullScreen;
            if (!Init())
            {
                Console.WriteLine("Error");
                return;
            }
            //UPDATELOOP();
        }

        bool Init()
        {

            if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) < 0)
                return false;

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
                return false;
            }
            _Renderer = SDL_CreateRenderer(_Window, -1, 0);

            // everything succeeded lets draw the window
            // set to black 
            //This function expects Red, Green, Blue and   
            //  Alpha as color values  
            SDL_SetRenderDrawColor(_Renderer, 039, 058, 093, 255);

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
            SDL_Quit();
        }      
        ~Window()
        {
            Dispose();
        }

        public void Render() {        
            
            // clear the window to black  
            SDL_RenderClear(_Renderer);
            // show the window
    
            SDL_RenderPresent(_Renderer);
        }
        public void EventHandler() {
            if (SDL_PollEvent(out _event) == 1)
            {
                switch (_event.type)
                {
                    case SDL_EventType.SDL_QUIT:
                        IsGameRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }    
        public void Update() {

        }

    }
}
