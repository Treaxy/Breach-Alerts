using Exiled.API.Interfaces;
using System.ComponentModel;
using UnityEngine;

namespace Komutbise
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Plugin debug?")]
        public bool Debug {  get; set; } = false;
        [Description("SCP-049 Breach alert announcement:")]
        public string SCP049Alert { get; set; } = "pitch_0.2 .g4 .g4 pitch_1 All Personnel . Keter Level SCP 049 Containment Breach detected . Please Evacuate Heavy Containment Zone Immediately pitch_0.2 .g4 .g4 pitch_1";
        [Description("SCP-096 Breach alert announcement:")]
        public string SCP096Alert { get; set; } = "pitch_0.2 .g4 .g4 pitch_1 All Personnel . Euclid Level SCP 096 Containment Breach detected . Please Evacuate Light Containment Zone Immediately pitch_0.2 .g4 .g4 pitch_1";
        [Description("SCP-173 Breach alert announcement:")]
        public string SCP173Alert { get; set; } = "pitch_0.2 .g4 .g4 pitch_1 All Personnel . Euclid Level SCP 173 Containment Breach detected . Please Evacuate Light Containment Zone Immediately pitch_0.2 .g4 .g4 pitch_1";
        [Description("SCP-939 Breach alert announcement:")]
        public string SCP939Alert { get; set; } = "pitch_0.2 .g4 .g4 pitch_1 All Personnel . Keter Level SCP 939 Containment Breach detected . Please Evacuate Light Containment Zone Immediately pitch_0.2 .g4 .g4 pitch_1";

    }
}
