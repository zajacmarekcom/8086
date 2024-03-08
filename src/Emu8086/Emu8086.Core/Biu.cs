using Emu8086.Core.Instructions;
using Emu8086.Core.Interfaces;
using Emu8086.Core.MemoryAddresses;

namespace Emu8086.Core;

public class Biu(Memory memory, SegmentRegisters segmentRegisters) : IBiu
{
    public ushort Read(IMemoryAddress address)
    {
        var high = memory[address.Address];
        var low = memory[address.Address + 1];

        return (ushort)((high << 8) | low);
    }

    public void Write(IMemoryAddress address, ushort value)
    {
        memory[address.Address] = (byte)(value >> 8);
        memory[address.Address + 1] = (byte)value;
    }

    public Instruction NextInstruction()
    {
        var firstByte = Read(new CombinedAddress(segmentRegisters.CS, segmentRegisters.IP));
        var opcodeInfo = OpcodeMap.Map[(ushort)(firstByte >> 8)];
        segmentRegisters.IP += 2;
        var instruction = new Instruction(opcodeInfo.Opcode);
        return instruction;
    }
}