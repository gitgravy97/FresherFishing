using Terraria.ModLoader;

//// Bind to Key :: basis for this file
// https://github.com/tModLoader/tModLoader/blob/1.4.4/ExampleMod/Common/Systems/KeybindSystem.cs
//// Bind Keybind to User :: need this once you want to toggle the system on or off
// https://github.com/tModLoader/tModLoader/blob/1.4.4/ExampleMod/Common/Players/ExampleKeybindPlayer.cs

namespace FresherFishing.Common.KeyTriggers
{
    // Acts as a container for keybinds
    public class KeybindSystem : ModSystem
    {
        public static ModKeybind FishingPanelToggleKeybind { get; private set; }

        public override void Load() {
            // Registers a new keybind
            // We localize keybinds by adding a Mods.{ModName}.Keybind.{KeybindName} entry to our localization files. The actual text displayed to english users is in en-US.hjson
            FishingPanelToggleKeybind = KeybindLoader.RegisterKeybind(Mod, "FishingPanelToggleKeybind", "F");
        }

        // Please see ExampleMod.cs' Unload() method for a detailed explanation of the unloading process.
        public override void Unload() {
            // Not required if your AssemblyLoadContext is unloading properly, but nulling out static fields can help you figure out what's keeping it loaded.
            FishingPanelToggleKeybind = null;
        }
    }
}