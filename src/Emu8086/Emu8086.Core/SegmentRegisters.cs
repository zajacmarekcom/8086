﻿namespace Emu8086.Core;

public class SegmentRegisters
{
    public ushort CS { get; set; } = 0;
    public ushort DS { get; set; }
    public ushort ES { get; set; }
    public ushort SS { get; set; }
    public ushort IP { get; set; } = 0;
    public ushort SP { get; set; }
    public ushort BP { get; set; }
    public ushort SI { get; set; }
    public ushort DI { get; set; }
}