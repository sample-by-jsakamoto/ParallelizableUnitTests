using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectA
{
    public class TestClassA
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Theory]
        [MemberData(nameof(Names))]
        public async Task TestMethodX(string _)
        {
            await Task.Delay(3000);
        }

        [Fact]
        public async Task TestMethodY()
        {
            await Task.Delay(3000);
        }
    }
}
