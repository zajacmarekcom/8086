using Emu8086.Core.InstructionHandlers;
using Emu8086.Core.Instructions;
using Emu8086.Core.Interfaces;

namespace Emu8086.Core;

public class InstructionHandlerFactory(IBiu biu, GeneralRegisters generalRegisters, FlagRegister flagRegister) : IInstructionHandlerFactory
{
    public IInstructionHandler GetHandler(Instruction instruction)
    {
        return instruction.Opcode switch
        {
            Opcodes.Mov => new MovInstructionHandler(biu, generalRegisters, flagRegister),
            Opcodes.Add => new AddInstructionHandler(biu, generalRegisters, flagRegister),
            Opcodes.Cmp => new CmpInstructionHandler(biu, generalRegisters, flagRegister),
            Opcodes.Push => new PushInstructionHandler(biu, generalRegisters, flagRegister),
            Opcodes.Pop => new PopInstructionHandler(biu, generalRegisters, flagRegister),
            _ => throw new NotImplementedException($"Opcode {instruction.Opcode} not implemented")
        };
    }
}