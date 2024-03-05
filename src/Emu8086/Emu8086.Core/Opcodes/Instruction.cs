namespace Emu8086.Core.Opcodes;

public abstract class Instruction
{
    private byte[] _set = new byte[6];
    public Opcodes Opcode { get; }
    
    
}