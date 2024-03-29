﻿using System.Text;
using Emu8086.Core.Instructions;

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
        if (line is null)
        {
            return Array.Empty<byte>();
        }

        var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var opcode = parts[0].ToUpperInvariant();
        var operands = parts[1..];

        var opcodeBytes = OpcodeToBytesMap.Map[opcode];
        var operandBytes = ParseOperands(operands);

        var bytes = new List<byte>((opcodeBytes.Length + operandBytes.Length)) { opcodeBytes.OpcodeByte };
        bytes.AddRange(operandBytes);

        return bytes.ToArray();
    }

    private byte[] ParseOperands(string[] operands)
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