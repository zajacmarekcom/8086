namespace Emu8086.Core.Instructions;

public class Instruction(byte[] bytes)
{
    private byte[] _set = bytes;

    public Opcodes Opcode => OpcodeMap.Map[bytes[0]].Opcode;
}