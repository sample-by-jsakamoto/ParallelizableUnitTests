using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectB
{
    public class TestClassC
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Theory]
        [MemberData(nameof(Names))]
        public async Task TestMethodW(string _)
        {
            await Task.Delay(3000);
        }
    }
}
