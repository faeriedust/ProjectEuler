using Problem73.Answer;
using Xunit;

namespace Problem1.Tests {
  public class Problem73Tests {
    [Fact]
    public void CountFractionsInRange() =>
      Assert.Equal(3, Problem73Answer.CountFractionsInRange(maxDenominator: 8));
  }
}
