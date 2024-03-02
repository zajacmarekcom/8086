namespace Emu8086.Core;

public class FlagRegister
{
    private ushort _flags;

    public FlagRegister(ushort flags)
    {
        _flags = flags;
    }

    public bool CarryFlag
    {
        get => (_flags & 1) == 1;
        set => _flags = (ushort)(value ? _flags | 1 : _flags & ~1);
    }
    
    public bool ParityFlag
    {
        get => (_flags & 4) == 4;
        set => _flags = (ushort)(value ? _flags | 4 : _flags & ~4);
    }
    
    public bool AuxiliaryCarryFlag
    {
        get => (_flags & 16) == 16;
        set => _flags = (ushort)(value ? _flags | 16 : _flags & ~16);
    }
    
    public bool ZeroFlag
    {
        get => (_flags & 64) == 64;
        set => _flags = (ushort)(value ? _flags | 64 : _flags & ~64);
    }
    
    public bool SignFlag
    {
        get => (_flags & 128) == 128;
        set => _flags = (ushort)(value ? _flags | 128 : _flags & ~128);
    }
    
    public bool TrapFlag
    {
        get => (_flags & 256) == 256;
        set => _flags = (ushort)(value ? _flags | 256 : _flags & ~256);
    }
    
    public bool InterruptEnableFlag
    {
        get => (_flags & 512) == 512;
        set => _flags = (ushort)(value ? _flags | 512 : _flags & ~512);
    }
    
    public bool DirectionFlag
    {
        get => (_flags & 1024) == 1024;
        set => _flags = (ushort)(value ? _flags | 1024 : _flags & ~1024);
    }
    
    public bool OverflowFlag
    {
        get => (_flags & 2048) == 2048;
        set => _flags = (ushort)(value ? _flags | 2048 : _flags & ~2048);
    }
}