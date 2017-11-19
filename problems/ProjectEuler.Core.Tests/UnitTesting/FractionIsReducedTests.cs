using ProjectEuler.Core.Fractions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class FractionIsReducedTests {
    [Theory, MemberData(nameof(ReducedTestData))]
    public void FractionIsReduced(EulerFraction fraction) =>
      Assert.True(fraction.IsReduced());

    public static IEnumerable<object[]> ReducedTestData() =>
      _ReducedTestData_Raw()
        .Select(x => new object[] { x })
        .ToArray();

    private static IEnumerable<EulerFraction> _ReducedTestData_Raw() {
      yield return EulerFraction.Create(2, 5);
    }


    [Theory, MemberData(nameof(NotReducedTestData))]
    public void FractionIsNotReduced(EulerFraction fraction) =>
      Assert.False(fraction.IsReduced());

    public static IEnumerable<object[]> NotReducedTestData() =>
      _NotReducedTestData_Raw()
        .Select(x => new object[] { x })
        .ToArray();

    private static IEnumerable<EulerFraction> _NotReducedTestData_Raw() {
      yield return EulerFraction.Create(3, 6);
    }
  }
}
