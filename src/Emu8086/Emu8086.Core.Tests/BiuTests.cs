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
        var address = new DirectAddressing(0x1000);
        var value = (ushort)0x1234;

        // Act
        biu.Write(address, value);
        var result = biu.Read(address);

        // Assert
        Assert.Equal(value, result);
    }
}