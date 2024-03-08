using Emu8086.Core.Interfaces;

namespace Emu8086.Core.MemoryAddresses;

public class CombinedAddress(ushort segment, ushort offset) : IMemoryAddress
{
    public uint Address => (uint)((segment << 4) + offset);
}