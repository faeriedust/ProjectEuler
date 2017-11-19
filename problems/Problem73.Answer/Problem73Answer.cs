using ProjectEuler.Core;
using System.Linq;

namespace Problem73.Answer {
  public static class Problem73Answer {

    public static long CountFractionsInRangeWithMaxDenominator(long maxDenominator) =>
      EulerEnumerable.Range(1, maxDenominator)
        .Select(Problem73Answer.CountFractionsInRangeWithSpecificDenominator)
        .Sum();

    public static long CountFractionsInRangeWithSpecificDenominator(long denominator) =>
      EulerEnumerable.RangeFromTo(denominator / 3, denominator / 2)
        .Where(numerator => EulerMathHelpers.FindHighestCommonFactor(numerator, denominator) == 1)
        .Count();
  }
}
