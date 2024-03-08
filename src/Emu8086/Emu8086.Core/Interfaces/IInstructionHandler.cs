using Emu8086.Core.Instructions;

namespace Emu8086.Core.Interfaces;

public interface IInstructionHandler
{
    void HandleInstruction(Instruction instruction);
}