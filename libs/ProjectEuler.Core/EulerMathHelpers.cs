using System;

namespace ProjectEuler.Core {
  public static class EulerMathHelpers {
    public static long FindHighestCommonFactor(long a, long b) {

      long findHCF(long smaller, long larger) {
        var remainder = larger - ((larger / smaller) * smaller);

        if(remainder == 0) {
          return smaller;
        } else {
          return findHCF(remainder, smaller);
        }
      }
      return findHCF(Math.Min(a, b), Math.Max(a, b));
    }

    public static long DivideByRoundUp(this long numerator, long denominator) {
      var quotient = numerator / denominator;
      if(quotient * denominator < numerator) {
        quotient++;
      }
      return quotient;
    }
    public static long DivideByRoundDown(this long numerator, long denominator) =>
      numerator / denominator;

    public static long FindNearestMultipleBoundedBelowBy(long step, long target) =>
      target.DivideByRoundUp(step) * step;

    public static long FindNearestMultipleBoundedAboveBy(long step, long target) =>
      target.DivideByRoundDown(step) * step;

  }
}
