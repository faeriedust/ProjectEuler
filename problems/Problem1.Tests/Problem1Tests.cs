using Problem1.Answer;
using Xunit;

namespace Problem1.Tests {
  public class Problem1Tests {
    [Fact]
    public void Problem1_SumOfMultiplesOfThreeOrFiveLessThan10_Is23() {
      Assert.Equal(23, Problem1Answer.SumMultiplesOfThreeOrFiveLessThan(10));
    }

    [Fact]
    public void Problem1_SumOfMultiplesOfThreeOrFiveLessThan1000_Is233168() {
      Assert.Equal(233168, Problem1Answer.SumMultiplesOfThreeOrFiveLessThan(1000));
    }
  }
}
