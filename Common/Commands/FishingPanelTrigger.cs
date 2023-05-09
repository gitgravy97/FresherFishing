using FresherFishing.Common.Systems;
using Terraria;
using Terraria.ModLoader;

namespace FresherFishing.Common.Commands;

public class ChatTriggerFishingPanel : ModCommand
{
    // CommandType.Chat means that command can be used in Chat in SP and MP
    public override CommandType Type => CommandType.Chat;

    // The desired text to trigger this command will be `/test`
    public override string Command => "fish";

    // A short description of this command
    public override string Description => "test fishing ui setup";

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        Main.NewText("Triggered Fishing Test Command");
        ModContent.GetInstance<FishingUISystem>().ToggleFishingUI();
    }
}