using System.Collections.Generic;

namespace ProjectEuler.Core {
  public static class EulerEnumerable {
    public static IEnumerable<long> Range(long start, long count) {
      while(count-- > 0) {
        yield return start++;
      }
    }

    public static IEnumerable<long> RangeFromTo(long from, long to) {
      while(from < to) {
        yield return from++;
      }
    }
  }
}
