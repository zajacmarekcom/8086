using Emu8086.Core.Interfaces;

namespace Emu8086.Core;

public class Cpu(
    GeneralRegisters generalGeneralRegisters,
    FlagRegister flagRegister,
    SegmentRegisters segmentRegisters,
    Biu biu,
    IInstructionHandlerFactory instructionHandlerFactory)
{
    public void Tick()
    {
        var instruction = biu.NextInstruction();
        var handler = instructionHandlerFactory.GetHandler(instruction);
        handler.HandleInstruction(instruction);
    }
}