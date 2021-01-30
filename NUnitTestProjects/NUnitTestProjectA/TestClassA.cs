using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestProjectA
{
    [Parallelizable(ParallelScope.All)]
    public class TestClassA
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Test]
        [TestCaseSource(nameof(Names))]
        public async Task TestMethodX(string _)
        {
            await Task.Delay(3000);
        }

        [Test]
        public async Task TestMethodY()
        {
            await Task.Delay(3000);
        }
    }
}