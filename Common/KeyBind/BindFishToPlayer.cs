using FresherFishing.Common.KeyTriggers;
using Terraria;
using Terraria.ID;
using Terraria.GameInput;
using Terraria.ModLoader;
using FresherFishing.Common.Systems;
using Microsoft.Xna.Framework;
using FresherFishing.Common.Systems;


namespace FresherFishing.Common.KeyBind
{
    public class PlayerFishKey : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggerSet)
        {
            if (FishKeyBindSystem.FishingKeyBind.JustPressed)
            {
                Main.NewText("TEST");
            }
        }
    }
}