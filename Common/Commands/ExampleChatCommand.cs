using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace FresherFishing.Common.Commands;

public class ChatTriggerExample : ModCommand
{
    // CommandType.Chat means that command can be used in Chat in SP and MP
    public override CommandType Type => CommandType.Chat;

    // The desired text to trigger this command will be `/test`
    public override string Command => "test";

    // A short description of this command
    public override string Description => "developer testing command";

    public override void Action(CommandCaller caller, string input, string[] args)
    {
        Main.NewText("Triggered Chat Command");
        Main.NewText("Display Width: " + Main.screenWidth.ToString());
        Main.NewText("Display Height: " + Main.screenHeight.ToString());
        Main.NewText("Display Point: " + Main.ScreenSize.ToString());
    }
}