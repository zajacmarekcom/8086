using Emu8086.Core.Opcodes;

namespace Emu8086.Core.Interfaces;

public interface IInstructionHandler
{
    void HandleInstruction(Instruction instruction);
}