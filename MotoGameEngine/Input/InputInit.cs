using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDL2.SDL;
using static SDL2.SDL.SDL_Keycode;

namespace MotoGameEngine
{
    class InputInit
    {
        // return enume SDL keycode alternative for keycode
        public Dictionary<KeyCode, SDL_Keycode> kecodefinder = new Dictionary<KeyCode, SDL_Keycode>();

        // add alternatives
        public InputInit()
        {
            kecodefinder.Add(KeyCode.UNKNOWN, SDL_Keycode.SDLK_UNKNOWN);
            kecodefinder.Add(KeyCode.RETURN, SDL_Keycode.SDLK_RETURN);
            kecodefinder.Add(KeyCode.ESCAPE, SDL_Keycode.SDLK_ESCAPE);
            kecodefinder.Add(KeyCode.BACKSPACE, SDL_Keycode.SDLK_BACKSPACE);
            kecodefinder.Add(KeyCode.TAB, SDL_Keycode.SDLK_TAB);
            kecodefinder.Add(KeyCode.SPACE, SDL_Keycode.SDLK_SPACE);
            kecodefinder.Add(KeyCode.EXCLAIM, SDL_Keycode.SDLK_EXCLAIM);
            kecodefinder.Add(KeyCode.QUOTEDBL, SDL_Keycode.SDLK_QUOTE);
            kecodefinder.Add(KeyCode.HASH, SDL_Keycode.SDLK_HASH);
            kecodefinder.Add(KeyCode.PERCENT, SDL_Keycode.SDLK_PERCENT);
            kecodefinder.Add(KeyCode.DOLLAR, SDL_Keycode.SDLK_DOLLAR);
            kecodefinder.Add(KeyCode.AMPERSAND, SDL_Keycode.SDLK_AMPERSAND);
            kecodefinder.Add(KeyCode.QUOTE, SDL_Keycode.SDLK_QUOTE);
            kecodefinder.Add(KeyCode.LEFTPAREN, SDL_Keycode.SDLK_LEFTPAREN);
            kecodefinder.Add(KeyCode.RIGHTPAREN, SDL_Keycode.SDLK_KP_RIGHTPAREN);
            kecodefinder.Add(KeyCode.ASTERISK, SDL_Keycode.SDLK_ASTERISK);
            kecodefinder.Add(KeyCode.PLUS, SDL_Keycode.SDLK_PLUS);
            kecodefinder.Add(KeyCode.COMMA, SDL_Keycode.SDLK_COLON);
            kecodefinder.Add(KeyCode.MINUS, SDL_Keycode.SDLK_MINUS);
            kecodefinder.Add(KeyCode.PERIOD, SDL_Keycode.SDLK_PERIOD);
            kecodefinder.Add(KeyCode.SLASH, SDL_Keycode.SDLK_SLASH);
            kecodefinder.Add(KeyCode.k_0, SDL_Keycode.SDLK_0);
            kecodefinder.Add(KeyCode.k_1, SDL_Keycode.SDLK_1);
            kecodefinder.Add(KeyCode.k_2, SDL_Keycode.SDLK_2);
            kecodefinder.Add(KeyCode.k_3, SDL_Keycode.SDLK_3);
            kecodefinder.Add(KeyCode.k_4, SDL_Keycode.SDLK_4);
            kecodefinder.Add(KeyCode.k_5, SDL_Keycode.SDLK_5);
            kecodefinder.Add(KeyCode.k_6, SDL_Keycode.SDLK_6);
            kecodefinder.Add(KeyCode.k_7, SDL_Keycode.SDLK_7);
            kecodefinder.Add(KeyCode.k_8, SDL_Keycode.SDLK_8);
            kecodefinder.Add(KeyCode.k_9, SDL_Keycode.SDLK_9);
            kecodefinder.Add(KeyCode.COLON, SDL_Keycode.SDLK_COLON);
            kecodefinder.Add(KeyCode.SEMICOLON, SDL_Keycode.SDLK_SEMICOLON);
            kecodefinder.Add(KeyCode.LESS, SDL_Keycode.SDLK_LESS);
            kecodefinder.Add(KeyCode.EQUALS, SDL_Keycode.SDLK_EQUALS);
            kecodefinder.Add(KeyCode.GREATER, SDL_Keycode.SDLK_GREATER);
            kecodefinder.Add(KeyCode.QUESTION, SDL_Keycode.SDLK_QUESTION);
            kecodefinder.Add(KeyCode.AT, SDL_Keycode.SDLK_AT);

            kecodefinder.Add(KeyCode.LEFTBRACKET, SDL_Keycode.SDLK_LEFTBRACKET);
            kecodefinder.Add(KeyCode.BACKSLASH, SDL_Keycode.SDLK_BACKSLASH);
            kecodefinder.Add(KeyCode.RIGHTBRACKET, SDL_Keycode.SDLK_RIGHTBRACKET);
            kecodefinder.Add(KeyCode.CARET, SDL_Keycode.SDLK_CARET);
            kecodefinder.Add(KeyCode.UNDERSCORE, SDL_Keycode.SDLK_UNDERSCORE);
            kecodefinder.Add(KeyCode.BACKQUOTE, SDL_Keycode.SDLK_BACKQUOTE);
            kecodefinder.Add(KeyCode.a, SDLK_a);
            kecodefinder.Add(KeyCode.b, SDLK_b);
            kecodefinder.Add(KeyCode.c, SDLK_c);
            kecodefinder.Add(KeyCode.d, SDLK_d);
            kecodefinder.Add(KeyCode.e, SDLK_e);
            kecodefinder.Add(KeyCode.f, SDLK_f);
            kecodefinder.Add(KeyCode.g, SDLK_g);
            kecodefinder.Add(KeyCode.h, SDLK_h);
            kecodefinder.Add(KeyCode.i, SDLK_i);
            kecodefinder.Add(KeyCode.j, SDLK_j);
            kecodefinder.Add(KeyCode.k, SDLK_k);
            kecodefinder.Add(KeyCode.l, SDLK_l);
            kecodefinder.Add(KeyCode.m, SDLK_m);
            kecodefinder.Add(KeyCode.n, SDLK_n);
            kecodefinder.Add(KeyCode.o, SDLK_o);
            kecodefinder.Add(KeyCode.p, SDLK_p);
            kecodefinder.Add(KeyCode.q, SDLK_q);
            kecodefinder.Add(KeyCode.r, SDLK_r);
            kecodefinder.Add(KeyCode.s, SDLK_s);
            kecodefinder.Add(KeyCode.t, SDLK_t);
            kecodefinder.Add(KeyCode.u, SDLK_u);
            kecodefinder.Add(KeyCode.v, SDLK_v);
            kecodefinder.Add(KeyCode.w, SDLK_w);
            kecodefinder.Add(KeyCode.x, SDLK_x);
            kecodefinder.Add(KeyCode.y, SDLK_y);
            kecodefinder.Add(KeyCode.z, SDLK_z);

            kecodefinder.Add(KeyCode.CAPSLOCK, SDLK_CAPSLOCK);

            kecodefinder.Add(KeyCode.F1, SDLK_F1);
            kecodefinder.Add(KeyCode.F2, SDLK_F2);
            kecodefinder.Add(KeyCode.F3, SDLK_F3);
            kecodefinder.Add(KeyCode.F4, SDLK_F4);
            kecodefinder.Add(KeyCode.F5, SDLK_F5);
            kecodefinder.Add(KeyCode.F6, SDLK_F6);
            kecodefinder.Add(KeyCode.F7, SDLK_F7);
            kecodefinder.Add(KeyCode.F8, SDLK_F8);
            kecodefinder.Add(KeyCode.F9, SDLK_F9);
            kecodefinder.Add(KeyCode.F10, SDLK_F10);
            kecodefinder.Add(KeyCode.F11, SDLK_F11);
            kecodefinder.Add(KeyCode.F12, SDLK_F12);

            kecodefinder.Add(KeyCode.PRINTSCREEN, SDLK_PRINTSCREEN);
            kecodefinder.Add(KeyCode.SCROLLLOCK, SDLK_SCROLLLOCK);
            kecodefinder.Add(KeyCode.PAUSE, SDLK_PAUSE);
            kecodefinder.Add(KeyCode.INSERT, SDLK_INSERT);
            kecodefinder.Add(KeyCode.HOME, SDLK_HOME);
            kecodefinder.Add(KeyCode.PAGEUP, SDLK_PAGEUP);
            kecodefinder.Add(KeyCode.DELETE, SDLK_DELETE);
            kecodefinder.Add(KeyCode.END, SDLK_END);
            kecodefinder.Add(KeyCode.PAGEDOWN, SDLK_PAGEDOWN);
            kecodefinder.Add(KeyCode.RIGHT, SDLK_RIGHT);
            kecodefinder.Add(KeyCode.LEFT, SDLK_LEFT);
            kecodefinder.Add(KeyCode.DOWN, SDLK_DOWN);
            kecodefinder.Add(KeyCode.UP, SDLK_UP);

            kecodefinder.Add(KeyCode.NUMLOCKCLEAR, SDLK_NUMLOCKCLEAR);
            kecodefinder.Add(KeyCode.KP_DIVIDE, SDLK_KP_DIVIDE);
            kecodefinder.Add(KeyCode.KP_MULTIPLY, SDLK_KP_MULTIPLY);
            kecodefinder.Add(KeyCode.KP_MINUS, SDLK_KP_MINUS);
            kecodefinder.Add(KeyCode.KP_PLUS, SDLK_KP_PLUS);
            kecodefinder.Add(KeyCode.KP_ENTER, SDLK_KP_ENTER);
            kecodefinder.Add(KeyCode.KP_1, SDLK_KP_1);
            kecodefinder.Add(KeyCode.KP_2, SDLK_KP_2);
            kecodefinder.Add(KeyCode.KP_3, SDLK_KP_3);
            kecodefinder.Add(KeyCode.KP_4, SDLK_KP_4);
            kecodefinder.Add(KeyCode.KP_5, SDLK_KP_5);
            kecodefinder.Add(KeyCode.KP_6, SDLK_KP_6);
            kecodefinder.Add(KeyCode.KP_7, SDLK_KP_7);
            kecodefinder.Add(KeyCode.KP_8, SDLK_KP_8);
            kecodefinder.Add(KeyCode.KP_9, SDLK_KP_9);
            kecodefinder.Add(KeyCode.KP_0, SDLK_KP_0);
            kecodefinder.Add(KeyCode.KP_PERIOD, SDLK_KP_PERIOD);

            kecodefinder.Add(KeyCode.APPLICATION, SDLK_APPLICATION);
            kecodefinder.Add(KeyCode.POWER, SDLK_POWER);
            kecodefinder.Add(KeyCode.KP_EQUALS, SDLK_KP_EQUALS);
            kecodefinder.Add(KeyCode.F13, SDLK_F13);
            kecodefinder.Add(KeyCode.F14, SDLK_F14);
            kecodefinder.Add(KeyCode.F15, SDLK_F15);
            kecodefinder.Add(KeyCode.F16, SDLK_F16);
            kecodefinder.Add(KeyCode.F17, SDLK_F17);
            kecodefinder.Add(KeyCode.F18, SDLK_F18);
            kecodefinder.Add(KeyCode.F19, SDLK_F19);
            kecodefinder.Add(KeyCode.F20, SDLK_F20);
            kecodefinder.Add(KeyCode.F21, SDLK_F21);
            kecodefinder.Add(KeyCode.F22, SDLK_F22);
            kecodefinder.Add(KeyCode.F23, SDLK_F23);
            kecodefinder.Add(KeyCode.F24, SDLK_F24);
            kecodefinder.Add(KeyCode.EXECUTE, SDLK_EXECUTE);
            kecodefinder.Add(KeyCode.HELP, SDLK_HELP);
            kecodefinder.Add(KeyCode.MENU, SDLK_MENU);
            kecodefinder.Add(KeyCode.SELECT, SDLK_SELECT);
            kecodefinder.Add(KeyCode.STOP, SDLK_STOP);
            kecodefinder.Add(KeyCode.AGAIN, SDLK_AGAIN);
            kecodefinder.Add(KeyCode.UNDO, SDLK_UNDO);
            kecodefinder.Add(KeyCode.CUT, SDLK_CUT);
            kecodefinder.Add(KeyCode.COPY, SDLK_COPY);
            kecodefinder.Add(KeyCode.PASTE, SDLK_PASTE);
            kecodefinder.Add(KeyCode.FIND, SDLK_FIND);
            kecodefinder.Add(KeyCode.MUTE, SDLK_MUTE);
            kecodefinder.Add(KeyCode.VOLUMEUP, SDLK_VOLUMEUP);
            kecodefinder.Add(KeyCode.VOLUMEDOWN, SDLK_VOLUMEDOWN);
            kecodefinder.Add(KeyCode.KP_COMMA, SDLK_KP_COMMA);
            kecodefinder.Add(KeyCode.KP_EQUALSAS400, SDL_Keycode.SDLK_KP_EQUALSAS400);

            kecodefinder.Add(KeyCode.ALTERASE, SDLK_ALTERASE);
            kecodefinder.Add(KeyCode.SYSREQ, SDLK_SYSREQ);
            kecodefinder.Add(KeyCode.CANCEL, SDLK_CANCEL);
            kecodefinder.Add(KeyCode.CLEAR, SDLK_CLEAR);
            kecodefinder.Add(KeyCode.PRIOR, SDLK_PRIOR);
            kecodefinder.Add(KeyCode.RETURN2, SDLK_RETURN2);
            kecodefinder.Add(KeyCode.SEPARATOR, SDLK_SEPARATOR);
            kecodefinder.Add(KeyCode.OUT, SDLK_OUT);
            kecodefinder.Add(KeyCode.OPER, SDLK_OPER);
            kecodefinder.Add(KeyCode.CLEARAGAIN, SDLK_CLEARAGAIN);
            kecodefinder.Add(KeyCode.CRSEL, SDLK_CRSEL);
            kecodefinder.Add(KeyCode.EXSEL, SDLK_EXSEL);

            kecodefinder.Add(KeyCode.KP_00, SDLK_KP_00);
            kecodefinder.Add(KeyCode.KP_000, SDLK_KP_000);
            kecodefinder.Add(KeyCode.THOUSANDSSEPARATOR, SDLK_THOUSANDSSEPARATOR);

            kecodefinder.Add(KeyCode.DECIMALSEPARATOR, SDLK_DECIMALSEPARATOR);
            kecodefinder.Add(KeyCode.CURRENCYUNIT, SDLK_CURRENCYUNIT);
            kecodefinder.Add(KeyCode.CURRENCYSUBUNIT, SDLK_CURRENCYSUBUNIT);
            kecodefinder.Add(KeyCode.KP_LEFTPAREN, SDLK_KP_LEFTPAREN);
            kecodefinder.Add(KeyCode.KP_RIGHTPAREN, SDLK_KP_RIGHTPAREN);
            kecodefinder.Add(KeyCode.KP_LEFTBRACE, SDLK_KP_LEFTBRACE);
            kecodefinder.Add(KeyCode.KP_RIGHTBRACE, SDLK_KP_RIGHTBRACE);
            kecodefinder.Add(KeyCode.KP_TAB, SDLK_KP_TAB);
            kecodefinder.Add(KeyCode.KP_BACKSPACE, SDLK_KP_BACKSPACE);
            kecodefinder.Add(KeyCode.KP_A, SDLK_KP_A);
            kecodefinder.Add(KeyCode.KP_B, SDLK_KP_B);
            kecodefinder.Add(KeyCode.KP_C, SDLK_KP_C);
            kecodefinder.Add(KeyCode.KP_D, SDLK_KP_D);
            kecodefinder.Add(KeyCode.KP_E, SDLK_KP_E);
            kecodefinder.Add(KeyCode.KP_F, SDLK_KP_F);
            kecodefinder.Add(KeyCode.KP_XOR, SDLK_KP_XOR);
            kecodefinder.Add(KeyCode.KP_POWER, SDLK_KP_POWER);
            kecodefinder.Add(KeyCode.KP_PERCENT, SDLK_KP_PERCENT);
            kecodefinder.Add(KeyCode.KP_LESS, SDLK_KP_LESS);
            kecodefinder.Add(KeyCode.KP_GREATER, SDLK_KP_GREATER);
            kecodefinder.Add(KeyCode.KP_AMPERSAND, SDLK_KP_AMPERSAND);
            kecodefinder.Add(KeyCode.KP_DBLAMPERSAND, SDLK_KP_DBLAMPERSAND);
            kecodefinder.Add(KeyCode.KP_VERTICALBAR, SDLK_KP_VERTICALBAR);
            kecodefinder.Add(KeyCode.KP_DBLVERTICALBAR, SDLK_KP_DBLVERTICALBAR);
            kecodefinder.Add(KeyCode.KP_COLON, SDLK_KP_COLON);
            kecodefinder.Add(KeyCode.KP_HASH, SDLK_KP_HASH);
            kecodefinder.Add(KeyCode.KP_SPACE, SDLK_KP_SPACE);
            kecodefinder.Add(KeyCode.KP_AT, SDLK_KP_AT);
            kecodefinder.Add(KeyCode.KP_EXCLAM, SDLK_KP_EXCLAM);
            kecodefinder.Add(KeyCode.KP_MEMSTORE, SDLK_KP_MEMSTORE);
            kecodefinder.Add(KeyCode.KP_MEMRECALL, SDLK_KP_MEMRECALL);
            kecodefinder.Add(KeyCode.KP_MEMCLEAR, SDLK_KP_MEMCLEAR);
            kecodefinder.Add(KeyCode.KP_MEMADD, SDLK_KP_MEMADD);
            kecodefinder.Add(KeyCode.KP_MEMSUBTRACT, SDLK_KP_MEMSUBTRACT);
            kecodefinder.Add(KeyCode.KP_MEMMULTIPLY, SDLK_KP_MEMMULTIPLY);
            kecodefinder.Add(KeyCode.KP_MEMDIVIDE, SDLK_KP_MEMDIVIDE);
            kecodefinder.Add(KeyCode.KP_PLUSMINUS, SDLK_KP_PLUSMINUS);
            kecodefinder.Add(KeyCode.KP_CLEAR, SDLK_KP_CLEAR);
            kecodefinder.Add(KeyCode.KP_CLEARENTRY, SDLK_KP_CLEARENTRY);
            kecodefinder.Add(KeyCode.KP_BINARY, SDLK_KP_BINARY);
            kecodefinder.Add(KeyCode.KP_OCTAL, SDLK_KP_OCTAL);
            kecodefinder.Add(KeyCode.KP_DECIMAL, SDLK_KP_DECIMAL);
            kecodefinder.Add(KeyCode.KP_HEXADECIMAL, SDLK_KP_HEXADECIMAL);

            kecodefinder.Add(KeyCode.LCTRL, SDLK_LCTRL);
            kecodefinder.Add(KeyCode.LSHIFT, SDLK_LSHIFT);
            kecodefinder.Add(KeyCode.LALT, SDLK_LALT);
            kecodefinder.Add(KeyCode.LGUI, SDLK_LGUI);
            kecodefinder.Add(KeyCode.RCTRL, SDLK_RCTRL);
            kecodefinder.Add(KeyCode.RSHIFT, SDLK_RSHIFT);
            kecodefinder.Add(KeyCode.RALT, SDLK_RALT);
            kecodefinder.Add(KeyCode.RGUI, SDLK_RGUI);

            kecodefinder.Add(KeyCode.MODE, SDLK_MODE);

            kecodefinder.Add(KeyCode.AUDIONEXT, SDLK_AUDIONEXT);
            kecodefinder.Add(KeyCode.AUDIOPREV, SDLK_AUDIOPREV);
            kecodefinder.Add(KeyCode.AUDIOSTOP, SDLK_AUDIOSTOP);
            kecodefinder.Add(KeyCode.AUDIOPLAY, SDLK_AUDIOPLAY);
            kecodefinder.Add(KeyCode.AUDIOMUTE, SDLK_AUDIOMUTE);
            kecodefinder.Add(KeyCode.MEDIASELECT, SDLK_MEDIASELECT);
            kecodefinder.Add(KeyCode.WWW, SDLK_WWW);
            kecodefinder.Add(KeyCode.MAIL, SDLK_MAIL);
            kecodefinder.Add(KeyCode.CALCULATOR, SDLK_CALCULATOR);
            kecodefinder.Add(KeyCode.COMPUTER, SDLK_COMPUTER);
            kecodefinder.Add(KeyCode.AC_SEARCH, SDLK_AC_SEARCH);
            kecodefinder.Add(KeyCode.AC_HOME, SDLK_AC_HOME);
            kecodefinder.Add(KeyCode.AC_BACK, SDLK_AC_BACK);
            kecodefinder.Add(KeyCode.AC_FORWARD, SDLK_AC_FORWARD);
            kecodefinder.Add(KeyCode.AC_STOP, SDLK_AC_STOP);
            kecodefinder.Add(KeyCode.AC_REFRESH, SDLK_AC_REFRESH);
            kecodefinder.Add(KeyCode.AC_BOOKMARKS, SDLK_AC_BOOKMARKS);

            kecodefinder.Add(KeyCode.BRIGHTNESSDOWN, SDLK_BRIGHTNESSDOWN);
            kecodefinder.Add(KeyCode.BRIGHTNESSUP, SDLK_BRIGHTNESSUP);
            kecodefinder.Add(KeyCode.DISPLAYSWITCH, SDLK_DISPLAYSWITCH);
            kecodefinder.Add(KeyCode.KBDILLUMTOGGLE, SDLK_KBDILLUMTOGGLE);
            kecodefinder.Add(KeyCode.KBDILLUMDOWN, SDLK_KBDILLUMDOWN);
            kecodefinder.Add(KeyCode.KBDILLUMUP, SDLK_KBDILLUMUP);
            kecodefinder.Add(KeyCode.EJECT, SDLK_EJECT);
            kecodefinder.Add(KeyCode.SLEEP, SDLK_SLEEP);
        }
    }
    // keycodes
    public enum KeyCode
    {
        KP_CLEARENTRY,
        UNKNOWN,
        RETURN,
        ESCAPE,
        BACKSPACE,
        TAB,
        SPACE,
        EXCLAIM,
        QUOTEDBL,
        HASH,
        PERCENT,
        DOLLAR,
        AMPERSAND,
        QUOTE,
        LEFTPAREN,
        RIGHTPAREN,
        ASTERISK,
        PLUS,
        COMMA,
        MINUS,
        PERIOD,
        SLASH,
        k_0,
        k_1,
        k_2,
        k_3,
        k_4,
        k_5,
        k_6,
        k_7,
        k_8,
        k_9,
        COLON,
        SEMICOLON,
        LESS,
        EQUALS,
        GREATER,
        QUESTION,
        AT,

        LEFTBRACKET,
        BACKSLASH,
        RIGHTBRACKET,
        CARET,
        UNDERSCORE,
        BACKQUOTE,
        a,
        b,
        c,
        d,
        e,
        f,
        g,
        h,
        i,
        j,
        k,
        l,
        m,
        n,
        o,
        p,
        q,
        r,
        s,
        t,
        u,
        v,
        w,
        x,
        y,
        z,

        CAPSLOCK,

        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,

        PRINTSCREEN,
        SCROLLLOCK,
        PAUSE,
        INSERT,
        HOME,
        PAGEUP,
        DELETE,
        END,
        PAGEDOWN,
        RIGHT,
        LEFT,
        DOWN,
        UP,

        NUMLOCKCLEAR,
        KP_DIVIDE,
        KP_MULTIPLY,
        KP_MINUS,
        KP_PLUS,
        KP_ENTER,
        KP_1,
        KP_2,
        KP_3,
        KP_4,
        KP_5,
        KP_6,
        KP_7,
        KP_8,
        KP_9,
        KP_0,
        KP_PERIOD,

        APPLICATION,
        POWER,
        KP_EQUALS,
        F13,
        F14,
        F15,
        F16,
        F17,
        F18,
        F19,
        F20,
        F21,
        F22,
        F23,
        F24,
        EXECUTE,
        HELP,
        MENU,
        SELECT,
        STOP,
        AGAIN,
        UNDO,
        CUT,
        COPY,
        PASTE,
        FIND,
        MUTE,
        VOLUMEUP,
        VOLUMEDOWN,
        KP_COMMA, S,
        KP_EQUALSAS400,

        ALTERASE,
        SYSREQ,
        CANCEL,
        CLEAR,
        PRIOR,
        RETURN2,
        SEPARATOR,
        OUT,
        OPER,
        CLEARAGAIN,
        CRSEL,
        EXSEL,

        KP_00,
        KP_000,
        THOUSANDSSEPARATOR,
        DECIMALSEPARATOR,
        CURRENCYUNIT,
        CURRENCYSUBUNIT,
        KP_LEFTPAREN,
        KP_RIGHTPAREN,
        KP_LEFTBRACE,
        KP_RIGHTBRACE,
        KP_TAB,
        KP_BACKSPACE,
        KP_A,
        KP_B,
        KP_C,
        KP_D,
        KP_E,
        KP_F,
        KP_XOR,
        KP_POWER,
        KP_PERCENT,
        KP_LESS,
        KP_GREATER,
        KP_AMPERSAND,
        KP_DBLAMPERSAND,
        KP_VERTICALBAR,
        KP_DBLVERTICALBAR,
        KP_COLON,
        KP_HASH,
        KP_SPACE,
        KP_AT,
        KP_EXCLAM,
        KP_MEMSTORE,
        KP_MEMRECALL,
        KP_MEMCLEAR,
        KP_MEMADD,
        KP_MEMSUBTRACT,
        KP_MEMMULTIPLY,
        KP_MEMDIVIDE,
        KP_PLUSMINUS,
        KP_CLEAR,
        KP_CLEARENTR,
        KP_BINARY,
        KP_OCTAL,
        KP_DECIMAL,
        KP_HEXADECIMAL,

        LCTRL,
        LSHIFT,
        LALT,
        LGUI,
        RCTRL,
        RSHIFT,
        RALT,
        RGUI,

        MODE,

        AUDIONEXT,
        AUDIOPREV,
        AUDIOSTOP,
        AUDIOPLAY,
        AUDIOMUTE,
        MEDIASELECT,
        WWW,
        MAIL,
        CALCULATOR,
        COMPUTER,
        AC_SEARCH,
        AC_HOME,
        AC_BACK,
        AC_FORWARD,
        AC_STOP,
        AC_REFRESH,
        AC_BOOKMARKS,

        BRIGHTNESSDOWN,
        BRIGHTNESSUP,
        DISPLAYSWITCH,
        KBDILLUMTOGGLE,
        KBDILLUMDOWN,
        KBDILLUMUP,
        EJECT,
        SLEEP
    }
    // mouse buttons
    public enum MouseButton
    {
        LEFT, RIGHT
    }
}
