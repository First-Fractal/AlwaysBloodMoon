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
            base.PreUpdateWorld();
        }
    }
}