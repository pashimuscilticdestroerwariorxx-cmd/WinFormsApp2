using AwesomeAssertions;
using WinFormsApp2;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void qq()
        {
            var Calc = new Calc();
            var result = Calc.GetPrice(1, 1);

            result.Should().Be(2);
        }
    }
}
