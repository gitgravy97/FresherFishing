using Terraria;
using Terraria.GameContent.UI.Elements;
using Microsoft.Xna.Framework;

namespace FresherFishing.Common.UI;

public class FishingPanel : UIPanel
{
    // Function runs one time when initially generating element
    public override void OnInitialize()
    {
        Width.Set((float)(Main.screenWidth * 0.05), 0);
        Height.Set((float)(Main.screenHeight * 0.5), 0);
        BackgroundColor = new Color(137, 207, 240);
    }

    // This function is how we're hooking in our re-rendering and ensuring scaling
    // upper-level UIState.update() will propagate down and trigger this update()
    public override void Update(GameTime gameTime)
    {
        Width.Set((float)(Main.screenWidth * 0.025), 0);
        Height.Set((float)(Main.screenHeight * 0.5), 0);
        BackgroundColor = new Color(137, 207, 240);
    }
}