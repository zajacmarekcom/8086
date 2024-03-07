using Emu8086.Core.Interfaces;
using Emu8086.Core.Opcodes;

namespace Emu8086.Core;

public class InstructionHandlerFactory : IInstructionHandlerFactory
{
    public IInstructionHandler GetHandler(Instruction instruction)
    {
        throw new NotImplementedException();
    }
}