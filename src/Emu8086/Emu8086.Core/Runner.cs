﻿using Emu8086.Core.Interfaces;
using Emu8086.Core.Opcodes;

namespace Emu8086.Core;

public class Runner(
    IBiu biu,
    FlagRegister flagRegister,
    Registers registers,
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