using Xunit;
using MyKeanLib;

namespace MyKeanLibtest;

public class UnitTest1
{
    [Fact]
    public void MyPow_2Numbers_2Pow3_ShouldBe8()
    {
        // arrange
        var lib = new MyKeanLibrary();
        double a = 2, b = 3;
        double expected = 8;

        // act
        double actual = lib.MyPow(a, b);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MyPow_3Numbers_2Pow3Pow4_ShouldBe4096()
    {
        // arrange
        var lib = new MyKeanLibrary();
        double a = 2, b = 3, c = 4;
        double expected = 4096;

        // act
        double actual = lib.MyPow(a, b, c);

        // assert
        Assert.Equal(expected, actual);
    }
}
