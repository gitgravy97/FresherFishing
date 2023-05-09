using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using FresherFishing.Common.UI;

// https://github.com/tModLoader/tModLoader/blob/1.4.4/ExampleMod/Common/UI/ExampleCoinsUI/ExampleCoinsUISystem.cs

namespace FresherFishing.Common.Systems;

[Autoload(Side = ModSide.Client)]
public class FishingUISystem : ModSystem
{
    private UserInterface fishingInterface;
    internal FishingUIState fishingUI;

    public void ToggleFishingUI()
    {
        if (fishingInterface?.CurrentState == fishingUI)
            fishingInterface?.SetState(null);
        else
            fishingInterface?.SetState(fishingUI);
    }

    public void HideFishingUI()
    {
        fishingInterface?.SetState(null);
    }

    public override void Load()
    {
        // define custom interface that can swap between UI states
        fishingInterface = new UserInterface();

        // define custom UIState
        fishingUI = new FishingUIState();

        // this .Activate() calls Initialize on UIState if not initialized
        // then it calls OnActivate, and then Activate, on every child element
        fishingUI.Activate();
    }

    public override void UpdateUI(GameTime gameTime)
    {
        // derive a better comment later
        if (fishingInterface?.CurrentState != null) fishingInterface?.Update(gameTime);
    }

    // Adds a custom layer to the vanilla layer list, so it'll call .draw(~) on your interface if it
    // has a state
    // also setting InterfaceScaleType to UI for appropriate UI scaling
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        var mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
        if (mouseTextIndex != -1)
            layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                "Fishing Mod :: yeehaw test time",
                delegate
                {
                    if (fishingInterface?.CurrentState != null) fishingInterface.Draw(Main.spriteBatch, new GameTime());

                    return true;
                },
                InterfaceScaleType.UI)
            );
    }
}