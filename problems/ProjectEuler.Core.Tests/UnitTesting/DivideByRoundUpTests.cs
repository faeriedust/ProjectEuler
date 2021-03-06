﻿using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class DivideByRoundUpTests {
    [Theory, MemberData(nameof(TestData))]
    public void DivideByRoundUp(long numerator, long denominator, long expectedResult) =>
      Assert.Equal(expectedResult, numerator.DivideByRoundUp(denominator));

    public static IEnumerable<object[]> TestData() =>
      _TestData_Raw()
        .Select(x => new object[] { x.Numerator, x.Denominator, x.Quotient })
        .ToArray();


    private static IEnumerable<(long Numerator, long Denominator, long Quotient)> _TestData_Raw() {
      yield return (5, 3, 2);
      yield return (6, 3, 2);
    }
  }
}
