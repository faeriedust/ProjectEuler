using ProjectEuler.Core;

namespace Problem1.Answer {
  public static class Problem1Answer {
    public static long SumMultiplesOfThreeOrFiveLessThan(long cap) =>
      Problem1Answer.SumArithmeticRange(1, cap - 1, 3)
       + Problem1Answer.SumArithmeticRange(1, cap - 1, 5)
       - Problem1Answer.SumArithmeticRange(1, cap - 1, 15);

    public static long SumArithmeticRange(long min, long max, long step) {
      var first = EulerMathHelpers.FindNearestMultipleBoundedBelowBy(step, min);
      var last = EulerMathHelpers.FindNearestMultipleBoundedAboveBy(step, max);

      var count = ((last - first) / step) + 1;

      return (long)(((first + last) / 2) * count);
    }
  }
}
