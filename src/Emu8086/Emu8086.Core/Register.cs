namespace Emu8086.Core;

public enum Register
{
    Al = 0b0000,
    Ah = 0b0100,
    Bl = 0b0011,
    Bh = 0b0111,
    Cl = 0b0001,
    Ch = 0b0101,
    Dl = 0b0010,
    Dh = 0b0110,
    Ax = 0b1000,
    Bx = 0b1011,
    Cx = 0b1001,
    Dx = 0b000,
    Si = 0b100,
    Di = 0b111,
    Sp = 0b110,
    Bp = 0b101,
    Cs = 0b001,
    Ds = 0b110,
    Ss = 0b010,
    Es = 0b000
}