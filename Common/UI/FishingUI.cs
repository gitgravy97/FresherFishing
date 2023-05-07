using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;
using UIText = Terraria.GameContent.UI.Elements.UIText;


namespace FresherFishing.Common.UI;

public class FishingUIState : UIState
{
    public FishingPanel fishingPanel;
    public FishingSlider fishingSlider;

    public override void OnInitialize()
    {
        // Container UI Element used to help manage placement of the pane
        // Placement written as an offset where top-left corner is (0,0)
        fishingPanel = new FishingPanel();
        SetRectangle(fishingPanel, left: 400f, top: 100f, width: 170f, height: 70f);

        // To add text to the panel
        // UIText testText = new UIText("yeehaw");
        // fishingPanel.Append(testText);

        fishingSlider = new FishingSlider();
        fishingPanel.Append(fishingSlider);

        // We need to actually append that panel back to our UI State
        Append(fishingPanel);
    }
    
    // Sets framing for parent element
    private void SetRectangle(UIElement uiElement, float left, float top, float width, float height) {
        uiElement.Left.Set(left, 0f);
        uiElement.Top.Set(top, 0f);
        uiElement.Width.Set(width, 0f);
        uiElement.Height.Set(height, 0f);
    }
    
}