using Problem1.Answer;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problem1.Tests {
  public class SumArithmeticRangeTests {
    [Theory, MemberData(nameof(TestData))]
    public void SumArithmeticRange(long min, long max, long step, long expectedSum) =>
      Assert.Equal(expectedSum, Problem1Answer.SumArithmeticRange(step, min, max));

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw().Select(x => new object[] { x.Min, x.Max, x.Step, x.Sum });

    private static IEnumerable<(long Min, long Max, long Step, long Sum)> _TestData_Raw() {
      yield return (1, 100, 1, 5050);
    }

  }
}
