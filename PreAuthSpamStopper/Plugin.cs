using System;
using System.Linq;
using HarmonyLib;
using LabApi.Features.Console;
using MEC;

namespace PreAuthSpamStopper
{
    public class Plugin: LabApi.Loader.Features.Plugins.Plugin
    {
        HarmonyLib.Harmony _harmony = new Harmony("preauthspamstopper");
        public override void Enable()
        {
            Timing.CallDelayed(1f, () =>
            {
                if (AppDomain.CurrentDomain.GetAssemblies().Any(s => s.FullName.Contains("cedmod", StringComparison.OrdinalIgnoreCase)))
                {
                    Logger.Error("CedMod already includes the functionality of this plugin, this plugin will not be enabled.");
                    return;
                }
                
                _harmony.PatchAll();
            });
        }

        public override void Disable()
        {
            _harmony.UnpatchAll(_harmony.Id);
        }

        public override string Name { get; } = "PreauthSpamStopper";
        public override string Description { get; } = "PreauthSpamStopper";
        public override string Author { get; } = "Ced777ric";
        public override Version Version { get; } = new Version(1, 2, 0);
        public override Version RequiredApiVersion { get; } = new Version(1, 0, 0);
        public override bool IsTransparent { get; } = true;
    }
}