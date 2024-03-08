namespace Emu8086.Parser;

public interface IAssemblerParser
{
    public byte[] Parse(string code);
}