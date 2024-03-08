namespace Emu8086.Core.Instructions;

public class Instruction(Opcodes opcode)
{
    private byte[] _set = new byte[6];

    public Opcodes Opcode { get; } = opcode;
}