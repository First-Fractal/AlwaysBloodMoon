using Terraria;
using Terraria.ModLoader;

namespace AlwaysBloodMoon
{
	public class AlwaysBloodMoon : Mod
	{
	}

	public class AlwaysBloodMoonSystem: ModSystem
	{
        public override void PreUpdateWorld()
        {
            if (Main.dayTime == false)
            {
                Main.bloodMoon = true;
            } else
            {
                Main.bloodMoon = false;
            }

            if (AlwaysBloodMoonConfig.Instance.AlwaysSolarEclipse && NPC.downedMechBossAny)
            {
                if (Main.dayTime == true)
                {
                    Main.bloodMoon = false;
                    Main.eclipse = true;
                }
                else
                {
                    Main.bloodMoon = true;
                    Main.eclipse = false;
                }
            }
            base.PreUpdateWorld();
        }
    }
}