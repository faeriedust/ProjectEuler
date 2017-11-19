using System;

namespace ProjectEuler.Core {
  public static class MathHelpers {
    public static long FindHighestCommonFactor(long a, long b) {

      long findHCF(long smaller, long larger) {
        var quotient = larger / smaller;
        var remainder = larger - (quotient * smaller);

        if(remainder == 0) {
          return quotient;
        } else {
          return findHCF(quotient, remainder);
        }
      }
      return findHCF(Math.Min(a, b), Math.Max(a, b));
    }
  }
}
