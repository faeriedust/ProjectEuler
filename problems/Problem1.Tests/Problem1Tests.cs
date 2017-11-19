using Xunit;
using Problem1.Answer;

namespace Problem1.Tests {
  public class Problem1Tests {
    [Fact]
    public void Problem1_SumOfMultiplesOfThreeOrFiveLessThan10_Is23() {
      Assert.Equal(23, Problem1.SumMultiplesOfThreeOrFiveLessThan(10));
    }

    [Fact]
    public void Problem1_SumOfMultiplesOfThreeOrFiveLessThan1000_Is233168() {
      Assert.Equal(233168, Problem1.SumMultiplesOfThreeOrFiveLessThan(1000));
    }
  }
}
