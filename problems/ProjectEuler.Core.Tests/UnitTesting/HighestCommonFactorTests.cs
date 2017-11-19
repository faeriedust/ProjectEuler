using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class HighestCommonFactorTests {
    [Theory, MemberData(nameof(HCFTestData))]
    public void FindHCF(long a, long b, long hcf) {
      var actualHcf = MathHelpers.FindHighestCommonFactor(a, b);

      Assert.Equal(hcf, actualHcf);
    }

    public static IEnumerable<object[]> HCFTestData() =>
      _HCFTestData_Raw()
        .Select(x => new object[] { x.A, x.B, x.HCF })
        .ToArray();


    private static IEnumerable<(long A, long B, long HCF)> _HCFTestData_Raw() {
      yield return (27, 36, 9);
      yield return (248, 492, 4);
    }

  }
}
