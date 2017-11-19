using Problem73.Answer;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problem1.Tests {
  public class Problem73_SpecificDenominatorTests {
    [Theory, MemberData(nameof(TestData))]
    public void CountFractionsInRange(long denominator, long expectedFractionCount) =>
      Assert.Equal(expectedFractionCount, Problem73Answer.CountFractionsInRangeWithSpecificDenominator(denominator));

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw().Select(x => new object[] { x.Denominator, x.CountedFractions });

    private static IEnumerable<(long Denominator, long CountedFractions)> _TestData_Raw() {
      yield return (0, 0);
      yield return (1, 0);
      yield return (2, 0);
      yield return (3, 0);
      yield return (4, 0);
      yield return (5, 1);
      yield return (6, 0);
      yield return (7, 1);
      yield return (8, 1);
    }

  }
}
