using System;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using LightColor;
using MEC;
using UnityEngine;

namespace Komutbise
{
    internal class ConsoleCommandd
    {
        [CommandHandler(typeof(RemoteAdminCommandHandler))]

        public class alert096 : ICommand
        {
            public string Command => "scp096alert";

            public string[] Aliases => new[] { "s096" };

            public string Description => "Breach alert";

            public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
            {
                if (!sender.CheckPermission("alerts"))
                {
                    response = "You dont have permission to do this.";
                    return false;
                }
                Timing.CallDelayed(1f, () =>
                {
                    Map.ChangeLightsColor(Color.red);
                });
                Timing.CallDelayed(2f, () =>
                {
                    Map.ChangeLightsColor(Color.clear);
                });
                Timing.CallDelayed(3f, () =>
                {
                    Map.ChangeLightsColor(Color.red);
                });
                Timing.CallDelayed(4f, () =>
                {
                    Map.ChangeLightsColor(Color.clear);
                });
                Cassie.Message(Plugin.Instance.Config.SCP096Alert, true, true, true);

                response = "Commmand send!";
                return true;
            }
        }
    }
}