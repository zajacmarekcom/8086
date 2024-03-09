using System.Text;

namespace Emu8086.Parser;

public class AssemblerParser : IAssemblerParser
{
    public byte[] Parse(string code)
    {
        var codeStream = GetStream(code);

        var bytes = new List<byte>();

        while (codeStream.Position < codeStream.Length)
        {
            var line = GetNextLine(codeStream);
            if (line is null)
            {
                break;
            }
            var instruction = ParseInstruction(line);
            bytes.AddRange(instruction);
        }

        return bytes.ToArray();
    }

    private ReadOnlySpan<byte> ParseInstruction(string? line)
    {
        throw new NotImplementedException();
    }

    private MemoryStream GetStream(string code)
    {
        var stream = new MemoryStream();
        var writer = new StreamWriter(stream);
        writer.Write(code);
        writer.Flush();
        stream.Position = 0;
        return stream;
    }

    private string? GetNextLine(MemoryStream stream)
    {
        var reader = new StreamReader(stream);
        return reader.ReadLine();
    }
}