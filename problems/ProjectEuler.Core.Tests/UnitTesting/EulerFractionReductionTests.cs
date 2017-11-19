using LanguageExt;
using ProjectEuler.Core.Fractions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class EulerFractionReductionTests {
    [Theory, MemberData(nameof(EulerFractionReductionTestData))]
    public void ReduceEulerFraction(EulerFraction input, EulerFraction reduced) =>
      Assert.Equal(reduced, input.Reduce());

    public static IEnumerable<object[]> EulerFractionReductionTestData() =>
      _EulerFractionReductionTestData_Raw()
        .Select(x => new object[] { x.Input, x.Reduced })
        .ToArray();


    private static IEnumerable<(EulerFraction Input, EulerFraction Reduced)> _EulerFractionReductionTestData_Raw() {
      yield return (EulerFraction.Create(4, 8), EulerFraction.Create(1, 2));
    }

  }
}
