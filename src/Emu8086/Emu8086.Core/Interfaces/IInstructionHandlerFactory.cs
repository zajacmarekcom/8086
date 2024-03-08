using Emu8086.Core.Instructions;

namespace Emu8086.Core.Interfaces;

public interface IInstructionHandlerFactory
{
    IInstructionHandler GetHandler(Instruction instruction);
}