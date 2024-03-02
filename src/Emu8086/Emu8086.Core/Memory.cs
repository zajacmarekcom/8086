namespace Emu8086.Core;

public class Memory
{
    private ushort[] _memory;
    
    public Memory(int size)
    {
        _memory = new ushort[size];
    }

    public Memory()
    {
        _memory = new ushort[0x10000];
    }
    
    public ushort this[ushort address]
    {
        get => _memory[address];
        set => _memory[address] = value;
    }
}