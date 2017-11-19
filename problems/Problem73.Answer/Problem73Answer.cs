using ProjectEuler.Core;
using System.Linq;

namespace Problem73.Answer {
  public static class Problem73Answer {

    public static long CountFractionsInRangeWithMaxDenominator(long maxDenominator) =>
      EulerEnumerable.Range(1, maxDenominator)
        .Select(Problem73Answer.CountFractionsInRangeWithSpecificDenominator)
        .Sum();

    public static long CountFractionsInRangeWithSpecificDenominator(long denominator) =>
      EulerEnumerable.RangeFromTo(denominator / 2, denominator / 3)
        .Where(numerator => MathHelpers.FindHighestCommonFactor(numerator, denominator) == 1)
        .Count();
  }
}
