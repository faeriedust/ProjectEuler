using System;

namespace Problem1.Answer {
  public static class Problem1Answer {
    public static long SumMultiplesOfThreeOrFiveLessThan(long cap) =>
      Problem1Answer.SumArithmeticRange(1, cap - 1, 3)
       + Problem1Answer.SumArithmeticRange(1, cap - 1, 5)
       - Problem1Answer.SumArithmeticRange(1, cap - 1, 15);
    //EulerEnumerable.Range(0, cap)
    //  .Where(i => i % 3 == 0 || i % 5 == 0)
    //  .Sum();

    public static long SumArithmeticRange(long min, long max, long step) {
      var first = Math.Ceiling((double)min / step) * step;
      var last = Math.Floor((double)max / step) * step;

      var count = ((last - first) / step) + 1;

      return (long)(((first + last) / 2) * count);
    }
  }
}
