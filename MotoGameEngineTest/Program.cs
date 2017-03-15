using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;
using static SDL2.SDL;  // add SDL class form namespace SDL2
using MotoGameEngine;
using static SDL2.SDL_image;

namespace MotoGameEngineTest
{
    class Program
    {

       
        static void Main(string[] args)
        {
            Window w = new Window("t", 800, 640, false);
            // w.Delay(5000);

            IntPtr _Texture; // the new SDL_Texture variable 
            SDL_Rect _sourceRectangle; // the first rectangle 
            SDL_Rect _destinationRectangle; // another rectangle 

            IntPtr _TempSurface = SDL_LoadBMP(Environment.CurrentDirectory + "/a.bmp");

            _Texture = SDL_CreateTextureFromSurface(w._Renderer, _TempSurface);
            SDL_FreeSurface(_TempSurface);
            int a;
            uint b;

            SDL_QueryTexture(_Texture,out b, out a, out _sourceRectangle.w, out _sourceRectangle.h);

            _destinationRectangle.x = _sourceRectangle.x = 0;
            _destinationRectangle.y = _sourceRectangle.y = 0;
            _destinationRectangle.w = _sourceRectangle.w;
            _destinationRectangle.h = _sourceRectangle.h;


            while (w.IsGameRunning)
            {
                w.EventHandler();
                w.Update();
                

                SDL_RenderClear(w._Renderer);

                SDL_RenderCopy(w._Renderer, _Texture,ref _sourceRectangle,ref _destinationRectangle);

                SDL_RenderPresent(w._Renderer);
                //SDL_SetRenderDrawColor(w._Renderer, 0, 0, 255, 255);
                //w.Render();
            }
            w.Dispose();
        }
    }


    


}
