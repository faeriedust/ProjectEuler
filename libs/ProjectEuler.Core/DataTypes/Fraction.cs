namespace ProjectEuler.Core.DataTypes {
  public class Fraction {
    private Fraction(int numerator, int denominator) {
      this.Numerator = numerator;
      this.Denominator = denominator;
    }

    public int Numerator { get; }
    public int Denominator { get; }

    public override string ToString() => $"{this.Numerator} / {this.Denominator}";

    public static Fraction Create(int numerator, int denominator) =>
      new Fraction(numerator, denominator);
  }
}
