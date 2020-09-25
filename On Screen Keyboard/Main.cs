using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;

namespace client
{
    public class Main : BaseScript
    {
        private static bool IsKeyboardOnScreen = true;
        public static string KeyboardText;
        
        public Main()
        {
          //Command
          API.RegisterCommand("newcall", new Action(ToggleKeyboard), false);
          
          //Tick
          Tick += KeyboardCheck;
        }
        
        private static async Task KeyboardCheck()
        {
            if (IsKeyboardOnScreen)
            {
                if (API.UpdateOnscreenKeyboard() == 1)
                {
                    KeyboardText = API.GetOnscreenKeyboardResult();
                    API.CancelOnscreenKeyboard();
                    IsKeyboardOnScreen = false;
                }
            }
        }
        
        private static void ToggleKeyboard()
        {
            API.DisplayOnscreenKeyboard(1, "", "", "Enter Call Details Here", "", "", "", 500);
            IsKeyboardOnScreen = true;
        }
    }
}    
        
        
       
