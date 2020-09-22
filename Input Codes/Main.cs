using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using System.Threading.Tasks;
using System;

namespace PROJECTNAME
{
    public class Main : BaseScript
    {
        public CreateCommands()
        {
            Tick += OnTick;
        }

        private static async Task OnTick()
        {
            if (Game.Player.Character.IsInVehicle())
            {
              Screen.DisplayHelpTextThisFrame("Press ~INPUT_PICKUP~ to toggle siren"); //THIS WILL SHOW THE "E" key or controller "LB" button
            }
        }
    }
}
