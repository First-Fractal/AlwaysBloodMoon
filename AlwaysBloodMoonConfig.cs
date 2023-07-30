using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace AlwaysBloodMoon
{
    [Label("$Mods.AlwaysBloodMoon.Config.Label")]
    public class AlwaysBloodMoonConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static AlwaysBloodMoonConfig Instance;

        [Header("$Mods.AlwaysBloodMoon.Config.Header.GeneralOptions")]

        [Label("$Mods.AlwaysBloodMoon.Config.AlwaysSolarEclipse.Label")]
        [Tooltip("$Mods.AlwaysBloodMoon.Config.AlwaysSolarEclipse.Tooltip")]
        [DefaultValue(false)]
        public bool AlwaysSolarEclipse;

        [Label("$Mods.AlwaysBloodMoon.Config.CountTheAmount.Label")]
        [Tooltip("$Mods.AlwaysBloodMoon.Config.CountTheAmount.Tooltip")]
        [DefaultValue(true)]
        public bool CountTheAmount;

        [Label("$Mods.AlwaysBloodMoon.Config.NPCspawnAtNight.Label")]
        [Tooltip("$Mods.AlwaysBloodMoon.Config.NPCspawnAtNight.Tooltip")]
        [DefaultValue(true)]
        public bool NPCspawnAtNight;
    }
}
