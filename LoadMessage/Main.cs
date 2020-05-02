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
            EventHandlers["playerSpawned"] += new Action(playerSpawned);
        }

        public static void playerSpawned()
        {
            Screen.ShowNotification("Notification goes here");
        }
    }
}
