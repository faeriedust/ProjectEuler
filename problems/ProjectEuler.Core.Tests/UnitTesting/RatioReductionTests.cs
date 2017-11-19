using LanguageExt;
using ProjectEuler.Core.Ratios;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class RatioReductionTests {
    [Theory, MemberData(nameof(FractionReductionTestData))]
    public void ReduceRatio(Ratio<long> input, Ratio<long> reduced) =>
      Assert.Equal(reduced, input.Reduce());

    public static IEnumerable<object[]> FractionReductionTestData() =>
      _FractionReductionTestData_Raw()
        .Select(x => new object[] { x.Input, x.Reduced })
        .ToArray();


    private static IEnumerable<(Ratio<long> Input, Ratio<long> Reduced)> _FractionReductionTestData_Raw() {
      yield return (new Ratio<long>(4, 8), new Ratio<long>(4, 2));
    }

  }
}
