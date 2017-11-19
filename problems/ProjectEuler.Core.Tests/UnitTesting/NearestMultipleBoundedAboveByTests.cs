using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class NearestMultipleBoundedAboveByTests {
    [Theory, MemberData(nameof(TestData))]
    public void NearestMultipleBoundedAboveBy(long step, long upperBound, long expectedResult) {
      var actual = EulerMathHelpers.FindNearestMultipleBoundedAboveBy(step, upperBound);

      Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw()
        .Select(x => new object[] { x.Step, x.UpperBound, x.Nearest })
        .ToArray();


    private static IEnumerable<(long Step, long UpperBound, long Nearest)> _TestData_Raw() {
      yield return (1, 100, 100);
      yield return (3, 100, 99);
    }
  }
}
