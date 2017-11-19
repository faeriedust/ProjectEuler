using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class HighestCommonFactorTests {
    [Theory, MemberData(nameof(HCFTestData))]
    public void FindHCF(long a, long b, long expectedHCF) {
      var actualHcf = MathHelpers.FindHighestCommonFactor(a, b);

      Assert.Equal(expectedHCF, actualHcf);
    }

    public static IEnumerable<object[]> HCFTestData() =>
      _HCFTestData_Raw()
        .Select(x => new object[] { x.A, x.B, x.ExpectedHCF })
        .ToArray();


    private static IEnumerable<(long A, long B, long ExpectedHCF)> _HCFTestData_Raw() {
      yield return (27, 36, 9);
    }

  }
}
