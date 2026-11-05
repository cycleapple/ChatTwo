using ModifierFlag = FFXIVClientStructs.FFXIV.Client.System.Input.KeyModifierFlag;
using Dalamud.Game.ClientState.Keys;

namespace ChatTwo.GameFunctions.Types;

internal class Keybind
{
    internal VirtualKey Key1 { get; init; }
    internal ModifierFlag Modifier1 { get; init; }

    internal VirtualKey Key2 { get; init; }
    internal ModifierFlag Modifier2 { get; init; }
}
