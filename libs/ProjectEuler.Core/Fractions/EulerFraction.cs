namespace ProjectEuler.Core.Fractions {
  public class EulerFraction {
    private EulerFraction(long numerator, long denominator) {
      this.Numerator = numerator;
      this.Denominator = denominator;
    }

    public long Numerator { get; }
    public long Denominator { get; }

    public override string ToString() => $"{this.Numerator} / {this.Denominator}";

    public static EulerFraction Create(long numerator, long denominator) =>
      new EulerFraction(numerator, denominator);
  }
}
