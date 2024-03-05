﻿namespace Emu8086.Core.Interfaces;

public interface IBiu
{
    ushort Read(IMemoryAddress address);
    void Write(IMemoryAddress address, ushort value);
}