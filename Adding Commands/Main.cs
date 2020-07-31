using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using System;

namespace TutorialProjectClient
{
    public class Main : BaseScript
    {
        public Main()
        {
            API.RegisterCommand("street", new Action(DisplayStreet), false);
        }

        private static void DisplayStreet()
        {
            var street = World.GetStreetName(Game.Player.Character.Position);
            Screen.ShowNotification("Current Street: " + street);
        }
    }
}
