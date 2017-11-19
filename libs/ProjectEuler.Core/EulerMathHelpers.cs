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

    public static long FindNearestMultipleBoundedBelowBy(long step, long target) =>
      (long)Math.Ceiling((double)target / step) * step;

    public static long FindNearestMultipleBoundedAboveBy(long step, long target) =>
      (long)Math.Floor((double)target / step) * step;

  }
}
