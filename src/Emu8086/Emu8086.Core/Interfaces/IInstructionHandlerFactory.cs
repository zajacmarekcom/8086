using Emu8086.Core.Opcodes;

namespace Emu8086.Core.Interfaces;

public interface IInstructionHandlerFactory
{
    IInstructionHandler GetHandler(Instruction instruction);
}