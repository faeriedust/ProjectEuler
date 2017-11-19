using ProjectEuler.Core;
using System.Linq;

namespace Problem73.Answer {
  public static class Problem73Answer {

    public static long CountFractionsInRangeWithMaxDenominator(long maxDenominator) =>
      EulerEnumerable.Range(1, maxDenominator)
        .Select(Problem73Answer.CountFractionsInRangeWithDenominator)
        .Sum();

    public static long CountFractionsInRangeWithDenominator(long denominator) {
      return 0;
    }
  }
}
