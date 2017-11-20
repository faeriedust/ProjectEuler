namespace Problem1.Answer {
  public static class Problem1Answer {
    public static long SumMultiplesOfThreeOrFiveLessThan(long cap) =>
      Problem1Answer.SumMultiplesLessThan(divisor: 3, cap: cap)
       + Problem1Answer.SumMultiplesLessThan(divisor: 5, cap: cap)
       - Problem1Answer.SumMultiplesLessThan(divisor: 15, cap: cap);


    public static long SumMultiplesLessThan(long divisor, long cap) =>
      Problem1Answer.SumOneToN((cap - 1) / divisor) * divisor;

    public static long SumOneToN(long n) =>
      (n * (n + 1)) / 2;
  }
}
