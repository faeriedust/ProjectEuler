using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class HighestCommonFactorTests {
    [Theory, MemberData(nameof(TestData))]
    public void FindHCF(long a, long b, long hcf) {
      var actualHCF = MathHelpers.FindHighestCommonFactor(a, b);

      Assert.Equal(hcf, actualHCF);
    }

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw()
        .Select(x => new object[] { x.A, x.B, x.HCF })
        .ToArray();


    private static IEnumerable<(long A, long B, long HCF)> _TestData_Raw() {
      yield return (27, 36, 9);
      yield return (248, 492, 4);
    }

  }
}
