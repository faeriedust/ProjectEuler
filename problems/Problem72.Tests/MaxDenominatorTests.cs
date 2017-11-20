using Problem72.Answer;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problem72.Tests {
  public class SpecifcDenominatorTests {
    [Theory, MemberData(nameof(TestData))]
    public void CountFractionsWithMaxDenominator(long maxDenominator, long expectedFractionCount) =>
      Assert.Equal(
        expectedFractionCount,
        Problem72Answer.CountReducedFractionsWithMaxDenominator(maxDenominator)
      );

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw().Select(x => new object[] { x.MaxDenominator, x.CountedFractions });

    private static IEnumerable<(long MaxDenominator, long CountedFractions)> _TestData_Raw() {
      yield return (0, 0);
      yield return (1, 0);
      yield return (2, 1);
      yield return (3, 3);
      yield return (4, 5);
      yield return (5, 9);
      yield return (6, 11);
      yield return (7, 17);
      yield return (8, 21);
    }
  }
}
