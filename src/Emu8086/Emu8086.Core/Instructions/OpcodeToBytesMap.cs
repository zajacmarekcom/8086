namespace Emu8086.Core.Instructions;

public static class OpcodeToBytesMap
{
    public static IDictionary<string, OpcodeByteInfo> Map { get; } = new Dictionary<string, OpcodeByteInfo>
    {
        { "ADD", new OpcodeByteInfo(0x00, 3) },
        { "PUSH", new OpcodeByteInfo(0x00, 3) },
        { "POP", new OpcodeByteInfo(0x00, 3) },
        { "MOV", new OpcodeByteInfo(0x00, 3) },
        { "INT", new OpcodeByteInfo(0x00, 3) },
    };
}