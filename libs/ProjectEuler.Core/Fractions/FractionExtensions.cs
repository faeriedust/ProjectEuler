namespace ProjectEuler.Core.Fractions {
  public static class FractionExtensions {
    public static EulerFraction Reduce(this EulerFraction fraction) {

      var hcf = MathHelpers.FindHighestCommonFactor(fraction.Numerator, fraction.Denominator);
      return EulerFraction.Create(fraction.Numerator / hcf, fraction.Denominator / hcf);
    }

    public static bool IsReduced(this EulerFraction fraction) =>
      fraction.Numerator < fraction.Denominator
        && MathHelpers.FindHighestCommonFactor(fraction.Numerator, fraction.Denominator) == 1;
  }
}
