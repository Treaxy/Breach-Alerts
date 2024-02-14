using System;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using LightColor;
using MEC;
using UnityEngine;

namespace Komutbise
{
    internal class ConsoleCommandddd
    {
        [CommandHandler(typeof(RemoteAdminCommandHandler))]

        public class alert939 : ICommand
        {
            public string Command => "scp939alert";

            public string[] Aliases => new[] { "s939" };

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
                Cassie.Message(Plugin.Instance.Config.SCP939Alert, true, true, true);

                response = "Commmand send!";
                return true;
            }
        }
    }
}