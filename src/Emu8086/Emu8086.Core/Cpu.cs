namespace Emu8086.Core;

public class Cpu
{
    private readonly GeneralRegisters _generalGeneralRegisters;
    private readonly FlagRegister _flagRegister;
    private readonly SegmentRegisters _segmentRegisters;
    private readonly Biu _biu;
}