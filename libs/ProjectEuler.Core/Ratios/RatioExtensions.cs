using LanguageExt;

namespace ProjectEuler.Core.Ratios {
  public static class RatioExtensions {
    public static Ratio<long> Reduce(this Ratio<long> fraction) {
      var hcf = MathHelpers.FindHighestCommonFactor(fraction.Numerator, fraction.Denominator);
      return new Ratio<long>(fraction.Numerator / hcf, fraction.Denominator / hcf);
    }
  }
}
