using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectA
{
    public class UnitTestA1
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Theory]
        [MemberData(nameof(Names))]
        public async Task TestA1_1(string _)
        {
            await Task.Delay(3000);
        }

        [Fact]
        public async Task TestA1_2()
        {
            await Task.Delay(3000);
        }
    }
}
