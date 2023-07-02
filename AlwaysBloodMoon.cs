using Terraria;
using Terraria.ID;
using Terraria.Chat;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

namespace AlwaysBloodMoon
{
	public class AlwaysBloodMoon : Mod
	{
        public int bloodMoonCounter = 0;
        public int solarEclipseCounter = 0;
	}

	public class AlwaysBloodMoonSystem: ModSystem
	{
        static bool saidBloodCounter = false;
        static bool saidSolarCounter = false;
        AlwaysBloodMoon ABM = new AlwaysBloodMoon();

        public void Talk(string message, Color color)
        {
            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                Main.NewText(message, color);
            }
            else
            {
                ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(message), color);
            }
        }

        public override void PreUpdateWorld()
        {
            StolenTerrariaCode.UpdateTime_SpawnTownNPCs();
            if (Main.dayTime == false)
            {
                Main.bloodMoon = true;
                saidBloodCounter = false;
            } else
            {
                Main.bloodMoon = false;
            }

            if (AlwaysBloodMoonConfig.Instance.CountTheAmount == true && Main.time >= 0 && Main.time < 2 && Main.dayTime == true && saidBloodCounter == false)
            {
                ABM.bloodMoonCounter++;
                Talk(Language.GetTextValue("Mods.AlwaysBloodMoon.Chat.CountFront") + " " + ABM.bloodMoonCounter.ToString() + " " + Language.GetTextValue("Mods.AlwaysBloodMoon.Chat.CountBlood") + " " + Main.worldName + " " + Language.GetTextValue("Mods.AlwaysBloodMoon.Chat.CountBack"), Color.OrangeRed);
                saidBloodCounter = true;
            }

            if (AlwaysBloodMoonConfig.Instance.AlwaysSolarEclipse && NPC.downedMechBossAny)
            {
                if (Main.dayTime == true)
                {
                    Main.bloodMoon = false;
                    Main.eclipse = true;
                    saidSolarCounter = false;
                }
                else
                {
                    Main.bloodMoon = true;
                    Main.eclipse = false;
                }

                if (AlwaysBloodMoonConfig.Instance.CountTheAmount == true && Main.time >= 0 && Main.time < 2 && Main.dayTime == false && saidSolarCounter == false)
                {
                    ABM.solarEclipseCounter++;
                    Talk(Language.GetTextValue("Mods.AlwaysBloodMoon.Chat.CountFront") + " " + ABM.solarEclipseCounter.ToString() + " " + Language.GetTextValue("Mods.AlwaysBloodMoon.Chat.CountSolar") + " " + Main.worldName + " " + Language.GetTextValue("Mods.AlwaysBloodMoon.Chat.CountBack"), Color.DarkGoldenrod);
                    saidBloodCounter = true;
                }
            }

            base.PreUpdateWorld();
        }

        public override void SaveWorldData(TagCompound tag)
        {
            tag.Add("bloodMoonCounter", ABM.bloodMoonCounter);
            tag.Add("solarEclipseCounter", ABM.solarEclipseCounter);
            base.SaveWorldData(tag);
        }
        public override void LoadWorldData(TagCompound tag)
        {
            ABM.bloodMoonCounter = tag.GetAsInt("bloodMoonCounter");
            ABM.solarEclipseCounter = tag.GetAsInt("solarEclipseCounter");
            base.LoadWorldData(tag);
        }
    }
}