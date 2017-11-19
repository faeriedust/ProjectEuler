using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class NearestMultipleBoundedBelowByTests {
    [Theory, MemberData(nameof(TestData))]
    public void NearestMultipleBoundedBelowBy(long step, long lowerBound, long expectedResult) {
      var actual = EulerMathHelpers.FindNearestMultipleBoundedBelowBy(step, lowerBound);

      Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw()
        .Select(x => new object[] { x.Step, x.LowerBound, x.Nearest })
        .ToArray();


    private static IEnumerable<(long Step, long LowerBound, long Nearest)> _TestData_Raw() {
      yield return (1, 1, 1);
      yield return (3, 1, 3);
    }
  }
}
