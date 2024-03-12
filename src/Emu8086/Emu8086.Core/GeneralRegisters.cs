namespace Emu8086.Core;

public class GeneralRegisters
{
    public ushort AX { get; set; }
    public short AL
    {
        get => (short)(AX & 0xFF);
        set => AX = (ushort)((AX & 0xFF00) | (ushort)value);
    }
    public short AH
    {
        get => (short)((AX >> 8) & 0xFF);
        set => AX = (ushort)((AX & 0x00FF) | ((ushort)value << 8));
    }
    public ushort BX { get; set; }
    public short BL
    {
        get => (short)(BX & 0xFF);
        set => BX = (ushort)((BX & 0xFF00) | (ushort)value);
    }
    public short BH
    {
        get => (short)((BX >> 8) & 0xFF);
        set => BX = (ushort)((BX & 0x00FF) | ((ushort)value << 8));
    }
    public ushort CX { get; set; }
    public short CL
    {
        get => (short)(CX & 0xFF);
        set => CX = (ushort)((CX & 0xFF00) | (ushort)value);
    }
    public short CH
    {
        get => (short)((CX >> 8) & 0xFF);
        set => CX = (ushort)((CX & 0x00FF) | ((ushort)value << 8));
    }
    public ushort DX { get; set; }
    public short DL
    {
        get => (short)(DX & 0xFF);
        set => DX = (ushort)((DX & 0xFF00) | (ushort)value);
    }
    public short DH
    {
        get => (short)((DX >> 8) & 0xFF);
        set => DX = (ushort)((DX & 0x00FF) | ((ushort)value << 8));
    }
    public ushort SI { get; set; }
    public ushort DI { get; set; }
    public ushort BP { get; set; }
    public ushort SP { get; set; }
    public ushort IP { get; set; }
    public ushort CS { get; set; }
    public ushort DS { get; set; }
    public ushort ES { get; set; }
    public ushort SS { get; set; }
    public ushort FLAGS { get; set; }
    public bool CF
    {
        get => (FLAGS & 1) == 1;
        set => FLAGS = (ushort)(value ? FLAGS | 1 : FLAGS & 0xFFFE);
    }
    public bool PF
    {
        get => (FLAGS & 4) == 4;
        set => FLAGS = (ushort)(value ? FLAGS | 4 : FLAGS & 0xFFFB);
    }
    
    public bool AF
    {
        get => (FLAGS & 16) == 16;
        set => FLAGS = (ushort)(value ? FLAGS | 16 : FLAGS & 0xFFF7);
    }
    
    public bool ZF
    {
        get => (FLAGS & 64) == 64;
        set => FLAGS = (ushort)(value ? FLAGS | 64 : FLAGS & 0xFFBF);
    }
    
}