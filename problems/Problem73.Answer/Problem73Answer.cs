﻿using ProjectEuler.Core;
using ProjectEuler.Core.Fractions;
using System.Linq;

namespace Problem73.Answer {
  public static class Problem73Answer {

    public static long CountFractionsInRangeWithMaxDenominator(long maxDenominator) =>
      EulerEnumerable.Range(1, maxDenominator)
        .Select(Problem73Answer.CountFractionsInRangeWithSpecificDenominator)
        .Sum();

    public static long CountFractionsInRangeWithSpecificDenominator(long denominator) =>
      EulerEnumerable.RangeFromTo(denominator.DivideByRoundUp(3), denominator.DivideByRoundDown(2))
        .Select(numerator => EulerFraction.Create(numerator, denominator))
        .Where(fraction => fraction.IsReduced())
        .Count();
  }
}
