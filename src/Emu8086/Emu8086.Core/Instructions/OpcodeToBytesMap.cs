namespace Emu8086.Core.Instructions;

public static class OpcodeToBytesMap
{
    public static IDictionary<string, byte> Map { get; } = new Dictionary<string, byte>
    {
        { "ADD", 0x00 },
        { "PUSH", 0x50 },
        { "POP", 0x58 },
        { "MOV", 0xB0 },
        { "INT", 0xCD },
    };
}