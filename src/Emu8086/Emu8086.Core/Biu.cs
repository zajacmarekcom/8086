using Emu8086.Core.Interfaces;

namespace Emu8086.Core;

public class Biu(Memory memory, SegmentRegisters segmentRegisters) : IBiu
{
    public ushort Read(IMemoryAddress address)
    {
        var high = memory[address.Address];
        var low = memory[address.Address+1];
        
        return (ushort)((high << 8) | low);
    }

    public void Write(IMemoryAddress address, ushort value)
    {
        memory[address.Address] = (byte)(value >> 8);
        memory[address.Address+1] = (byte)value;
    }
}