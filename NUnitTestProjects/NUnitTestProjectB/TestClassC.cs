using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestProjectB
{
    [Parallelizable(ParallelScope.All)]
    public class TestClassC
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Test]
        [TestCaseSource(nameof(Names))]
        public async Task TestMethodW(string _)
        {
            await Task.Delay(3000);
        }
    }
}