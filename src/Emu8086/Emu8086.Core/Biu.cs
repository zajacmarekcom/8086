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

    public byte ReadByte(IMemoryAddress address)
    {
        return memory[address.Address];
    }

    public void Write(IMemoryAddress address, ushort value)
    {
        memory[address.Address] = (byte)(value >> 8);
        memory[address.Address + 1] = (byte)value;
    }

    public void WriteByte(IMemoryAddress address, byte value)
    {
        memory[address.Address] = value;
    }

    public void WriteWord(IMemoryAddress address, ushort value)
    {
        memory[address.Address] = (byte)(value >> 8);
        memory[address.Address + 1] = (byte)value;
    }

    public void WriteBytes(IMemoryAddress address, byte[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            memory[(uint)(address.Address + i)] = values[i];
        }
    }

    public Instruction NextInstruction()
    {
        var firstByte = ReadByte(new CombinedAddress(segmentRegisters.CS, segmentRegisters.IP));
        var opcodeInfo = ByteToOpcodeMap.Map[(byte)(firstByte >> 8)];
        segmentRegisters.IP += 1;
        var bytes = new List<byte>(6) { firstByte };
        for (int i = 0; i < opcodeInfo.Length - 1; i++)
        {
            bytes.Add(ReadByte(new CombinedAddress(segmentRegisters.CS, segmentRegisters.IP)));
            segmentRegisters.IP += 1;
        }

        var instruction = new Instruction(bytes.ToArray());
        return instruction;
    }
}