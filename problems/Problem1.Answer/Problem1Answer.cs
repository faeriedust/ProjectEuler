using ProjectEuler.Core;

namespace Problem1.Answer {
  public static class Problem1Answer {
    public static long SumMultiplesOfThreeOrFiveLessThan(long cap) =>
      Problem1Answer.SumArithmeticRange(step: 3, min: 1, max: cap - 1)
       + Problem1Answer.SumArithmeticRange(step: 5, min: 1, max: cap - 1)
       - Problem1Answer.SumArithmeticRange(step: 15, min: 1, max: cap - 1);

    public static long SumArithmeticRange(long step, long min, long max) {
      var first = EulerMathHelpers.FindNearestMultipleBoundedBelowBy(step, min);
      var last = EulerMathHelpers.FindNearestMultipleBoundedAboveBy(step, max);

      var count = ((last - first) / step) + 1;

      return (first + last) * count / 2;
    }
  }
}
