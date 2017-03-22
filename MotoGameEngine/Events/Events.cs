using System.Collections.Generic;
using static SDL2.SDL;
using static SDL2.SDL.SDL_EventType;

namespace MotoGameEngine
{
    class eventInit
    {
        // return enume SDL event alternative for Event
        public Dictionary<SDL_EventType, Event> eventfinder = new Dictionary<SDL_EventType, Event>();
        public eventInit()
        {
            eventfinder.Add(SDL_FIRSTEVENT, Event.FIRSTEVENT);
            eventfinder.Add(SDL_QUIT, Event.QUIT);
            eventfinder.Add(SDL_WINDOWEVENT, Event.WINDOWEVENT);
            eventfinder.Add(SDL_SYSWMEVENT, Event.SYSWMEVENT);
            eventfinder.Add(SDL_KEYDOWN, Event.KEYDOWN);
            eventfinder.Add(SDL_KEYUP, Event.KEYUP);
            eventfinder.Add(SDL_TEXTEDITING, Event.TEXTEDITING);
            eventfinder.Add(SDL_TEXTINPUT, Event.TEXTINPUT);
            eventfinder.Add(SDL_MOUSEMOTION, Event.MOUSEMOTION);
            eventfinder.Add(SDL_MOUSEBUTTONDOWN, Event.MOUSEBUTTONDOWN);
            eventfinder.Add(SDL_MOUSEBUTTONUP, Event.MOUSEBUTTONUP);
            eventfinder.Add(SDL_MOUSEWHEEL, Event.MOUSEWHEEL);
            eventfinder.Add(SDL_JOYAXISMOTION, Event.JOYAXISMOTION);
            eventfinder.Add(SDL_JOYBALLMOTION, Event.JOYBALLMOTION);
            eventfinder.Add(SDL_JOYHATMOTION, Event.JOYHATMOTION);
            eventfinder.Add(SDL_JOYBUTTONDOWN, Event.JOYBUTTONDOWN);
            eventfinder.Add(SDL_JOYBUTTONUP, Event.JOYBUTTONUP);
            eventfinder.Add(SDL_JOYDEVICEADDED, Event.JOYDEVICEADDED);
            eventfinder.Add(SDL_JOYDEVICEREMOVED, Event.JOYDEVICEREMOVED);
            eventfinder.Add(SDL_CONTROLLERAXISMOTION, Event.CONTROLLERAXISMOTION);
            eventfinder.Add(SDL_CONTROLLERBUTTONDOWN, Event.CONTROLLERBUTTONDOWN);
            eventfinder.Add(SDL_CONTROLLERBUTTONUP, Event.CONTROLLERBUTTONUP);
            eventfinder.Add(SDL_CONTROLLERDEVICEADDED, Event.CONTROLLERDEVICEADDED);
            eventfinder.Add(SDL_CONTROLLERDEVICEREMOVED, Event.CONTROLLERDEVICEREMOVED);
            eventfinder.Add(SDL_CONTROLLERDEVICEREMAPPED, Event.CONTROLLERDEVICEREMAPPED);
            eventfinder.Add(SDL_FINGERDOWN, Event.FINGERDOWN);
            eventfinder.Add(SDL_FINGERUP, Event.FINGERUP);
            eventfinder.Add(SDL_FINGERMOTION, Event.FINGERMOTION);
            eventfinder.Add(SDL_DOLLARGESTURE, Event.DOLLARGESTURE);
            eventfinder.Add(SDL_DOLLARRECORD, Event.DOLLARRECORD);
            eventfinder.Add(SDL_MULTIGESTURE, Event.MULTIGESTURE);
            eventfinder.Add(SDL_CLIPBOARDUPDATE, Event.CLIPBOARDUPDATE);
            eventfinder.Add(SDL_DROPFILE, Event.DROPFILE);
            eventfinder.Add(SDL_DROPTEXT, Event.DROPTEXT);
            eventfinder.Add(SDL_DROPBEGIN, Event.DROPBEGIN);
            eventfinder.Add(SDL_DROPCOMPLETE, Event.DROPCOMPLETE);
            eventfinder.Add(SDL_AUDIODEVICEADDED, Event.AUDIODEVICEADDED);
            eventfinder.Add(SDL_AUDIODEVICEREMOVED, Event.AUDIODEVICEREMOVED);
            eventfinder.Add(SDL_RENDER_TARGETS_RESET, Event.RENDER_TARGETS_RESET);
            eventfinder.Add(SDL_RENDER_DEVICE_RESET, Event.RENDER_DEVICE_RESET);
            eventfinder.Add(SDL_USEREVENT, Event.USEREVENT);
            eventfinder.Add(SDL_LASTEVENT, Event.LASTEVENT);
        }

    }

    public enum Event
    {
        NULL,
        FIRSTEVENT,

        /* Application events */
        QUIT,

        /* Window events */
        WINDOWEVENT,
        SYSWMEVENT,

        /* Keyboard events */
        KEYDOWN,
        KEYUP,
        TEXTEDITING,
        TEXTINPUT,

        /* Mouse events */
        MOUSEMOTION,
        MOUSEBUTTONDOWN,
        MOUSEBUTTONUP,
        MOUSEWHEEL,

        /* Joystick events */
        JOYAXISMOTION,
        JOYBALLMOTION,
        JOYHATMOTION,
        JOYBUTTONDOWN,
        JOYBUTTONUP,
        JOYDEVICEADDED,
        JOYDEVICEREMOVED,

        /* Game controller events */
        CONTROLLERAXISMOTION,
        CONTROLLERBUTTONDOWN,
        CONTROLLERBUTTONUP,
        CONTROLLERDEVICEADDED,
        CONTROLLERDEVICEREMOVED,
        CONTROLLERDEVICEREMAPPED,

        /* Touch events */
        FINGERDOWN,
        FINGERUP,
        FINGERMOTION,

        /* Gesture events */
        DOLLARGESTURE,
        DOLLARRECORD,
        MULTIGESTURE,

        /* Clipboard events */
        CLIPBOARDUPDATE,

        /* Drag and drop events */
        DROPFILE,
        /* Only available in 2.0.4 or higher */
        DROPTEXT,
        DROPBEGIN,
        DROPCOMPLETE,

        /* Audio hotplug events */
        /* Only available in SDL 2.0.4 or higher */
        AUDIODEVICEADDED,
        AUDIODEVICEREMOVED,

        /* Render events */
        /* Only available in SDL 2.0.2 or higher */
        RENDER_TARGETS_RESET,
        /* Only available in SDL 2.0.4 or higher */
        RENDER_DEVICE_RESET,

        /* Events USEREVENT through LASTEVENT are for
         * your use, and should be allocated with
         * RegisterEvents()
         */
        USEREVENT,

        /* The last event, used for bouding arrays. */
        LASTEVENT
    }
}
