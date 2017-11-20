using ProjectEuler.Core;
using ProjectEuler.Core.Fractions;
using System.Linq;

namespace Problem72.Answer {
  public static class Problem72Answer {
    public static long CountReducedFractionsWithMaxDenominator(long maxDenominator) =>
      EulerEnumerable.Range(1, maxDenominator)
        .Select(denominator => Problem72Answer.CountReducedFractionsForSpecificDenominator(denominator))
        .Sum();
    public static long CountReducedFractionsForSpecificDenominator(long denominator) =>
      EulerEnumerable.Range(1, denominator - 1)
        .Select(numerator => EulerFraction.Create(numerator, denominator))
        .Where(fraction => fraction.IsReduced())
        .Count();
  }
}
