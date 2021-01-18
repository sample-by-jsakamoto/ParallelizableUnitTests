using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestProjectB
{
    [Parallelizable(ParallelScope.All)]
    public class UnitTestB1
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Test]
        [TestCaseSource(nameof(Names))]
        public async Task TestB1_1(string _)
        {
            await Task.Delay(3000);
        }
    }
}