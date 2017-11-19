using System.Linq;

namespace Problem1.Answer {
  public static class Problem1Answer {
    public static long SumMultiplesOfThreeOrFiveLessThan(long cap) =>
      Enumerable.Range(0, cap)
        .Where(i => i % 3 == 0 || i % 5 == 0)
        .Sum();
  }
}
