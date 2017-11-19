using Problem1.Answer;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problem1.Tests {
  public class SumMultiplesOfThreeOrFiveBelowTests {
    [Theory, MemberData(nameof(TestData))]
    public void SumMultiplesOfThreeOrFiveBelow(long cap, long expectedSum) =>
      Assert.Equal(expectedSum, Problem1Answer.SumMultiplesOfThreeOrFiveLessThan(cap));

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw().Select(x => new object[] { x.Cap, x.Sum });

    private static IEnumerable<(long Cap, long Sum)> _TestData_Raw() {
      yield return (10, 23);
      yield return (1000, 233168);
    }

  }
}
