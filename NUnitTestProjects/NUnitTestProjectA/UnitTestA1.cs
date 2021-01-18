using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestProjectA
{
    [Parallelizable(ParallelScope.All)]
    public class UnitTestA1
    {
        public static IEnumerable<object[]> Names = new[] {
            new object[]{ "Alice" },
            new object[]{ "Bob" },
        };

        [Test]
        [TestCaseSource(nameof(Names))]
        public async Task TestA1_1(string _)
        {
            await Task.Delay(3000);
        }

        [Test]
        public async Task TestA1_2()
        {
            await Task.Delay(3000);
        }
    }
}