using System;
using System.Collections.Generic;

using SDL2;

namespace Microsoft.Xna.Framework.Input
{
	internal static class SDL2_KeyboardUtil
	{
		private static Dictionary<SDL.SDL_Keycode, Keys> INTERNAL_map;
		
		static SDL2_KeyboardUtil()
		{
			INTERNAL_map = new Dictionary<SDL.SDL_Keycode, Keys>();
            
			var values = Enum.GetValues(typeof(SDL.SDL_Keycode));
			
			foreach (SDL.SDL_Keycode sdlKey in values)
            {
				INTERNAL_map[sdlKey] = INTERNAL_ToXNA(sdlKey);
            }
		}
		
		static Keys INTERNAL_ToXNA(SDL.SDL_Keycode key)
		{
			switch (key)
			{
				case SDL.SDL_Keycode.SDLK_a:
					return Keys.A;
	                    
				case SDL.SDL_Keycode.SDLK_LALT:
					return Keys.LeftAlt;
	                    
				case SDL.SDL_Keycode.SDLK_RALT:
					return Keys.RightAlt;
	                    
				case SDL.SDL_Keycode.SDLK_b:
					return Keys.B;
	                    
				case SDL.SDL_Keycode.SDLK_BACKSPACE:
					return Keys.Back;
	                    
				case SDL.SDL_Keycode.SDLK_BACKSLASH:
					return Keys.OemBackslash;
	                    
				case SDL.SDL_Keycode.SDLK_LEFTBRACKET:
					return Keys.OemOpenBrackets;
	                    
				case SDL.SDL_Keycode.SDLK_RIGHTBRACKET:
					return Keys.OemCloseBrackets;
	                    
				case SDL.SDL_Keycode.SDLK_c:
					return Keys.C;
	                    
				case SDL.SDL_Keycode.SDLK_CAPSLOCK:
					return Keys.CapsLock;
	                    
				case SDL.SDL_Keycode.SDLK_KP_CLEAR:
					return Keys.OemClear;
	                    
				case SDL.SDL_Keycode.SDLK_COMMA:
					return Keys.OemComma;
	                    
				case SDL.SDL_Keycode.SDLK_LCTRL:
					return Keys.LeftControl;
	                    
				case SDL.SDL_Keycode.SDLK_RCTRL:
					return Keys.RightControl;
	                    
				case SDL.SDL_Keycode.SDLK_d:
					return Keys.D;
	                    
				case SDL.SDL_Keycode.SDLK_DELETE:
					return Keys.Delete;
	                    
				case SDL.SDL_Keycode.SDLK_DOWN:
					return Keys.Down;
	                    
				case SDL.SDL_Keycode.SDLK_e:
					return Keys.E;
	                    
				case SDL.SDL_Keycode.SDLK_END:
					return Keys.End;
	                    
				case SDL.SDL_Keycode.SDLK_RETURN:
					return Keys.Enter;
	                    
				case SDL.SDL_Keycode.SDLK_ESCAPE:
					return Keys.Escape;
	                    
				case SDL.SDL_Keycode.SDLK_f:
					return Keys.F;
	                    
				case SDL.SDL_Keycode.SDLK_F1:
					return Keys.F1;
	                    
				case SDL.SDL_Keycode.SDLK_F10:
					return Keys.F10;
	                    
				case SDL.SDL_Keycode.SDLK_F11:
					return Keys.F11;
	                    
				case SDL.SDL_Keycode.SDLK_F12:
					return Keys.F12;
	                    
				case SDL.SDL_Keycode.SDLK_F13:
					return Keys.F13;
	                    
				case SDL.SDL_Keycode.SDLK_F14:
					return Keys.F14;
	                    
				case SDL.SDL_Keycode.SDLK_F15:
					return Keys.F15;
	                    
				case SDL.SDL_Keycode.SDLK_F16:
					return Keys.F16;
	                    
				case SDL.SDL_Keycode.SDLK_F17:
					return Keys.F17;
	                    
				case SDL.SDL_Keycode.SDLK_F18:
					return Keys.F18;
	                    
				case SDL.SDL_Keycode.SDLK_F19:
					return Keys.F19;
	                    
				case SDL.SDL_Keycode.SDLK_F2:
					return Keys.F2;
	                    
				case SDL.SDL_Keycode.SDLK_F20:
					return Keys.F20;
	                    
				case SDL.SDL_Keycode.SDLK_F21:
					return Keys.F21;
	                    
				case SDL.SDL_Keycode.SDLK_F22:
					return Keys.F22;
	                    
				case SDL.SDL_Keycode.SDLK_F23:
					return Keys.F23;
	                    
				case SDL.SDL_Keycode.SDLK_F24:
					return Keys.F24;
	                    
				case SDL.SDL_Keycode.SDLK_F3:
					return Keys.F3;
	                    
				case SDL.SDL_Keycode.SDLK_F4:
					return Keys.F4;
	                    
				case SDL.SDL_Keycode.SDLK_F5:
					return Keys.F5;
	                    
				case SDL.SDL_Keycode.SDLK_F6:
					return Keys.F6;
	                    
				case SDL.SDL_Keycode.SDLK_F7:
					return Keys.F7;
	                    
				case SDL.SDL_Keycode.SDLK_F8:
					return Keys.F8;
	                    
				case SDL.SDL_Keycode.SDLK_F9:
					return Keys.F9;
	                    
				case SDL.SDL_Keycode.SDLK_g:
					return Keys.G;
	                    
				case SDL.SDL_Keycode.SDLK_h:
					return Keys.H;
	                    
				case SDL.SDL_Keycode.SDLK_HOME:
					return Keys.Home;
	                    
				case SDL.SDL_Keycode.SDLK_i:
					return Keys.I;
	                    
				case SDL.SDL_Keycode.SDLK_INSERT:
					return Keys.Insert;
	                    
				case SDL.SDL_Keycode.SDLK_j:
					return Keys.J;
	                    
				case SDL.SDL_Keycode.SDLK_k:
					return Keys.K;
	                    
				case SDL.SDL_Keycode.SDLK_KP_0:
					return Keys.NumPad0;
	                    
				case SDL.SDL_Keycode.SDLK_KP_1:
					return Keys.NumPad1;
	                    
				case SDL.SDL_Keycode.SDLK_KP_2:
					return Keys.NumPad2;
	                    
				case SDL.SDL_Keycode.SDLK_KP_3:
					return Keys.NumPad3;
	                    
				case SDL.SDL_Keycode.SDLK_KP_4:
					return Keys.NumPad4;
	                    
				case SDL.SDL_Keycode.SDLK_KP_5:
					return Keys.NumPad5;
	                    
				case SDL.SDL_Keycode.SDLK_KP_6:
					return Keys.NumPad6;
	                    
				case SDL.SDL_Keycode.SDLK_KP_7:
					return Keys.NumPad7;
	                    
				case SDL.SDL_Keycode.SDLK_KP_8:
					return Keys.NumPad8;
	                    
				case SDL.SDL_Keycode.SDLK_KP_9:
					return Keys.NumPad9;
	                    
				case SDL.SDL_Keycode.SDLK_KP_PLUS:
					return Keys.Add;
	                    
				case SDL.SDL_Keycode.SDLK_KP_DECIMAL:
					return Keys.Decimal;
	                    
				case SDL.SDL_Keycode.SDLK_KP_DIVIDE:
					return Keys.Divide;
	                    
				case SDL.SDL_Keycode.SDLK_KP_ENTER:
					return Keys.Enter;
	                    
				case SDL.SDL_Keycode.SDLK_KP_MINUS:
					return Keys.OemMinus;
	                    
				case SDL.SDL_Keycode.SDLK_KP_MULTIPLY:
					return Keys.Multiply;
	                    
				case SDL.SDL_Keycode.SDLK_l:
					return Keys.L;
	                    
				case SDL.SDL_Keycode.SDLK_LSHIFT:
					return Keys.LeftShift;
	                    
				case SDL.SDL_Keycode.SDLK_LGUI:
					return Keys.LeftWindows;
	                    
				case SDL.SDL_Keycode.SDLK_LEFT:
					return Keys.Left;
	                    
				case SDL.SDL_Keycode.SDLK_m:
					return Keys.M;
	                    
				case SDL.SDL_Keycode.SDLK_MINUS:
					return Keys.OemMinus;
	                    
				case SDL.SDL_Keycode.SDLK_n:
					return Keys.N;
	                    
				case SDL.SDL_Keycode.SDLK_NUMLOCKCLEAR:
					return Keys.NumLock;
	                    
				case SDL.SDL_Keycode.SDLK_0:
					return Keys.D0;
	                    
				case SDL.SDL_Keycode.SDLK_1:
					return Keys.D1;
	                    
				case SDL.SDL_Keycode.SDLK_2:
					return Keys.D2;
	                    
				case SDL.SDL_Keycode.SDLK_3:
					return Keys.D3;
	                    
				case SDL.SDL_Keycode.SDLK_4:
					return Keys.D4;
	                    
				case SDL.SDL_Keycode.SDLK_5:
					return Keys.D5;
	                    
				case SDL.SDL_Keycode.SDLK_6:
					return Keys.D6;
	                    
				case SDL.SDL_Keycode.SDLK_7:
					return Keys.D7;
	                    
				case SDL.SDL_Keycode.SDLK_8:
					return Keys.D8;
	                    
				case SDL.SDL_Keycode.SDLK_9:
					return Keys.D9;
	                    
				case SDL.SDL_Keycode.SDLK_o:
					return Keys.O;
	                    
				case SDL.SDL_Keycode.SDLK_p:
					return Keys.P;
	                    
				case SDL.SDL_Keycode.SDLK_PAGEDOWN:
					return Keys.PageDown;
	                    
				case SDL.SDL_Keycode.SDLK_PAGEUP:
					return Keys.PageUp;
	                    
				case SDL.SDL_Keycode.SDLK_PAUSE:
					return Keys.Pause;
	                    
				case SDL.SDL_Keycode.SDLK_PERIOD:
					return Keys.OemPeriod;
	                    
				case SDL.SDL_Keycode.SDLK_PLUS:
					return Keys.OemPlus;
	                    
				case SDL.SDL_Keycode.SDLK_PRINTSCREEN:
					return Keys.PrintScreen;
	                    
				case SDL.SDL_Keycode.SDLK_q:
					return Keys.Q;
	                    
				case SDL.SDL_Keycode.SDLK_QUOTE:
					return Keys.OemQuotes;
	                    
				case SDL.SDL_Keycode.SDLK_r:
					return Keys.R;
	                    
				case SDL.SDL_Keycode.SDLK_RIGHT:
					return Keys.Right;
	                    
				case SDL.SDL_Keycode.SDLK_RSHIFT:
					return Keys.RightShift;
	                    
				case SDL.SDL_Keycode.SDLK_RGUI:
					return Keys.RightWindows;
	                    
				case SDL.SDL_Keycode.SDLK_s:
					return Keys.S;
	                    
				case SDL.SDL_Keycode.SDLK_SCROLLLOCK:
					return Keys.Scroll;
	                    
				case SDL.SDL_Keycode.SDLK_SEMICOLON:
					return Keys.OemSemicolon;
	                    
				case SDL.SDL_Keycode.SDLK_SLASH:
					return Keys.OemQuestion;
	                    
				case SDL.SDL_Keycode.SDLK_SLEEP:
					return Keys.Sleep;
	                    
				case SDL.SDL_Keycode.SDLK_SPACE:
					return Keys.Space;
	                    
				case SDL.SDL_Keycode.SDLK_t:
					return Keys.T;
	                    
				case SDL.SDL_Keycode.SDLK_TAB:
					return Keys.Tab;
	                    
				case SDL.SDL_Keycode.SDLK_BACKQUOTE:
					return Keys.OemTilde;
	                    
				case SDL.SDL_Keycode.SDLK_u:
					return Keys.U;
	                    
				case SDL.SDL_Keycode.SDLK_UNKNOWN:
					return Keys.None;
	                    
				case SDL.SDL_Keycode.SDLK_UP:
					return Keys.Up;
	                    
				case SDL.SDL_Keycode.SDLK_v:
					return Keys.V;
	                    
				case SDL.SDL_Keycode.SDLK_w:
					return Keys.W;
	                    
				case SDL.SDL_Keycode.SDLK_x:
					return Keys.X;
				
				case SDL.SDL_Keycode.SDLK_y:
					return Keys.Y;
			
				case SDL.SDL_Keycode.SDLK_z:				
					return Keys.Z;
				
				default:
					return Keys.None;	                    
			}	
		}
			
		public static Keys ToXNA(SDL.SDL_Keycode key)
		{
			return INTERNAL_map[key];
		}
	}
}

