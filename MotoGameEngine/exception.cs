using System;

namespace MotoGameEngine
{
    public class Initializing_SDL : Exception
    {
        public Initializing_SDL(string message) : base(message) { }
    }

    public class Initializing_Window : Exception
    {
        public Initializing_Window(string message) : base(message) { }
    }

    public class Initializing : Exception
    {
        public Initializing(string message) : base(message) { }
    }
    public class Loading_Image : Exception
    {
        public Loading_Image(string message) : base(message) { }
    }    
}
