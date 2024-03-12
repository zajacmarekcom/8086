using Emu8086.Core.Instructions;
using Emu8086.Core.Interfaces;

namespace Emu8086.Core;

public class Runner(
    IBiu biu,
    FlagRegister flagRegister,
    GeneralRegisters generalRegisters,
    IInstructionHandlerFactory instructionHandlerFactory)
{
    public void Run()
    {
        while (true)
        {
            Tick();
        }
        // ReSharper disable once FunctionNeverReturns
    }

    public void Tick()
    {
        var instruction = FetchInstruction();
        var handler = instructionHandlerFactory.GetHandler(instruction);
        handler.HandleInstruction(instruction);
    }

    private Instruction FetchInstruction()
    {
        var instruction = biu.NextInstruction();
        return instruction;
    }
}