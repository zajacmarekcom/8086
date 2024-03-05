using Emu8086.Core.Interfaces;

namespace Emu8086.Core.MemoryAddresses;

public class DirectAddressing(ushort address) : IMemoryAddress
{
    public uint Address => address;
}