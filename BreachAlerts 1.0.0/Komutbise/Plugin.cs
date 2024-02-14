using System;
using Exiled.API.Features;
using Komutbise;

namespace LightColor
{
    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "Treaxy";

        public override string Name => "Breach Alerts";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(8, 8, 0);

        public override string Prefix => Name;

        public static Plugin Instance;

        public override void OnEnabled()
        {
            Instance = this;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;

            base.OnDisabled();
        }
    }
}