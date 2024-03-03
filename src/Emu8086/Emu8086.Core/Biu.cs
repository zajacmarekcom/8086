namespace Emu8086.Core;

public class Biu
{
    private readonly Memory _memory;

    public Biu(Memory memory)
    {
        _memory = memory;
    }

    public ushort Read(ushort address)
    {
        return _memory[address];
    }

    public void Write(ushort address, ushort value)
    {
        _memory[address] = value;
    }
}