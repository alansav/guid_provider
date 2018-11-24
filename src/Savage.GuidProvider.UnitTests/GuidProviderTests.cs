using Xunit;

namespace Savage.Providers
{
    public class GuidProviderTests
    {
        [Fact]
        public void NewGuid_returns_a_different_value_each_time()
        {
            var sut = new GuidProvider();

            var guid1 = sut.NewGuid();
            var guid2 = sut.NewGuid();

            Assert.NotEqual(guid1, guid2);
        }
    }
}
