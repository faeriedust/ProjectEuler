namespace ProjectEuler.Core.Fractions {
  public static class FractionExtensions {
    public static EulerFraction Reduce(this EulerFraction fraction) {

      var hcf = EulerMathHelpers.FindHighestCommonFactor(fraction.Numerator, fraction.Denominator);
      return EulerFraction.Create(fraction.Numerator / hcf, fraction.Denominator / hcf);
    }

    public static bool IsReduced(this EulerFraction fraction) =>
      EulerMathHelpers.FindHighestCommonFactor(fraction.Numerator, fraction.Denominator) == 1;

    public static double ToDouble(this EulerFraction fraction) =>
      (double)fraction.Numerator / fraction.Denominator;
  }
}
