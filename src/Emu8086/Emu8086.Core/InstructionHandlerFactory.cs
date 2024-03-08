using Emu8086.Core.InstructionHandlers;
using Emu8086.Core.Instructions;
using Emu8086.Core.Interfaces;

namespace Emu8086.Core;

public class InstructionHandlerFactory : IInstructionHandlerFactory
{
    public IInstructionHandler GetHandler(Instruction instruction)
    {
        return instruction.Opcode switch
        {
            Opcodes.Mov => new MovInstructionHandler(),
            Opcodes.Add => new AddInstructionHandler(),
            Opcodes.Cmp => new CmpInstructionHandler(),
            Opcodes.Push => new PushInstructionHandler(),
            Opcodes.Pop => new PopInstructionHandler(),
            _ => throw new NotImplementedException($"Opcode {instruction.Opcode} not implemented")
        };
    }
}