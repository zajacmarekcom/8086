using Emu8086.Core.Instructions;
using Emu8086.Core.Interfaces;

namespace Emu8086.Core.InstructionHandlers;

public class PopInstructionHandler(IBiu biu, GeneralRegisters generalRegisters, FlagRegister flagRegister)
    : IInstructionHandler
{
    public void HandleInstruction(Instruction instruction)
    {
        throw new NotImplementedException();
    }
}