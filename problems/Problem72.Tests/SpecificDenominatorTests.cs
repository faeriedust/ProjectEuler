using Problem72.Answer;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problem72.Tests {
  public class SpecificDenominatorTests {
    [Theory, MemberData(nameof(TestData))]
    public void CountFractionsWithDenominator(long denominator, long expectedFractionCount) =>
      Assert.Equal(
        expectedFractionCount,
        Problem72Answer.CountReducedFractionsForSpecificDenominator(denominator)
      );

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw().Select(x => new object[] { x.Denominator, x.CountedFractions });

    private static IEnumerable<(long Denominator, long CountedFractions)> _TestData_Raw() {
      yield return (0, 0);
      yield return (1, 0);
      yield return (2, 1);
      yield return (3, 2);
      yield return (4, 2);
      yield return (5, 4);
      yield return (6, 2);
      yield return (7, 6);
      yield return (8, 4);
    }
  }
}
