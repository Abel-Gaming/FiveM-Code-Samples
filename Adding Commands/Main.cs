using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using System;

namespace MyResourceNameClient
{
    public class Class1 : BaseScript
    {
        public Class1()
        {
            API.RegisterCommand("Discord", new Action(discord), false);
        }

        public static void discord()
        {
            Screen.ShowNotification("Discord URL here"); //Discord URL will show as a notification when the player does /Discord
        }
    }
}
