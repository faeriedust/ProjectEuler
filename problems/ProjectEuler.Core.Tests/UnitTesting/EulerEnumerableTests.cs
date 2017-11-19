using System.Linq;
using Xunit;

namespace ProjectEuler.Core.Tests.UnitTesting {
  public class EulerEnumerableTests {
    [Fact]
    public void Range1To100_Has100Elements() {
      Assert.Equal(100, EulerEnumerable.RangeFromTo(1, 100).Count());
    }
  }
}
