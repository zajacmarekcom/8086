using Emu8086.Core.Opcodes;

namespace Emu8086.Core.Interfaces;

public interface IBiu
{
    ushort Read(IMemoryAddress address);
    void Write(IMemoryAddress address, ushort value);
    Instruction NextInstruction();
}