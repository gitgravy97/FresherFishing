using Terraria;
using Terraria.GameContent.UI.Elements;
using Microsoft.Xna.Framework;
using Terraria.UI;

namespace FresherFishing.Common.UI;

// I feel like this should be UIElement but UIElement won't let me pull backgroundColor... hmmm...
public class FishingSlider : UIPanel
{
    // Function runs one time when initially generating element
    public override void OnInitialize()
    {
        Width.Set((float)(Main.screenWidth * 0.025), 0);
        Height.Set((float)(Main.screenHeight * 0.05), 0);
        BackgroundColor = new Color(0, 0, 205);
    }

    // This function is how we're hooking in our re-rendering and ensuring scaling
    // upper-level UIState.update() will propagate down and trigger this update()
    public override void Update(GameTime gameTime)
    {
        Width.Set((float)(Main.screenWidth * 0.025), 0);
        Height.Set((float)(Main.screenHeight * 0.05), 0);
        BackgroundColor = new Color(0, 0, 205);
    }
}