using Emu8086.Core.Instructions;

namespace Emu8086.Core.Interfaces;

public interface IBiu
{
    ushort Read(IMemoryAddress address);
    byte ReadByte(IMemoryAddress address);
    void Write(IMemoryAddress address, ushort value);
    void WriteByte(IMemoryAddress address, byte value);
    void WriteWord(IMemoryAddress address, ushort value);
    void WriteBytes(IMemoryAddress address, byte[] values);
    Instruction NextInstruction();
}