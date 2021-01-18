using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectB
{
    public class UnitTestB1
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Theory]
        [MemberData(nameof(Names))]
        public async Task TestB1_1(string _)
        {
            await Task.Delay(3000);
        }
    }
}
