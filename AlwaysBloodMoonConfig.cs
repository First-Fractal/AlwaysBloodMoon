﻿using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
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
    }
}