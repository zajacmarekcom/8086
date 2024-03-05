using System.Collections.ObjectModel;

namespace Emu8086.Core;

public class Memory
{
    private readonly byte[] _memory;
    
    public Memory(uint size)
    {
        _memory = new byte[size];
    }

    public Memory()
    {
        _memory = new byte[0xFFFFF];
    }
    
    public byte this[uint address]
    {
        get => _memory[address];
        set => _memory[address] = value;
    }
}