using Emu8086.Core.Instructions;
using Emu8086.Core.MemoryAddresses;

namespace Emu8086.Core.Tests;

public class BiuTests
{
    [Fact]
    public void When_WriteToMemory_Expect_ValueIsWritten()
    {
        var memory = new Memory();
        // Arrange
        var biu = new Biu(memory, new SegmentRegisters());
        var address = new DirectAddress(0x1000);
        var value = (ushort)0x1234;

        // Act
        biu.Write(address, value);
        var result = biu.Read(address);

        // Assert
        Assert.Equal(value, result);
    }
    
    [Fact]
    public void When_ReadFirstInstruction_Then_Expect_OpcodeIsCorrect()
    {
        var memory = new Memory();
        var segmentRegisters = new SegmentRegisters();
        // Arrange
        var biu = new Biu(memory, segmentRegisters);
        var address = new CombinedAddress(segmentRegisters.CS, segmentRegisters.IP);
        var value = (ushort)0x8900;
        biu.Write(address, value);

        // Act
        var result = biu.NextInstruction();

        // Assert
        Assert.Equal(Opcodes.Mov, result.Opcode);
    }
}