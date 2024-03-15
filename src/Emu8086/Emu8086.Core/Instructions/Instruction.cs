namespace Emu8086.Core.Instructions;

public class Instruction(byte[] bytes)
{
    public Opcodes Opcode => ByteToOpcodeMap.Map[bytes[0]].Opcode;
    
    public bool DBit => (bytes[0] & 0b0000_0010) != 0;
    public WordMode WBit => (bytes[0] & 0b0000_0001) != 0 ? WordMode.Word : WordMode.Byte;
    
    public ModRm ModRm => (ModRm)(bytes[1] & 0b1100_0000);
    
    public Register Reg => (Register)(bytes[1] & 0b0011_1000);
}