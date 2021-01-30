using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestProjectA
{
    [Parallelizable(ParallelScope.All)]
    public class TestClassB
    {
        [Test]
        public async Task TestMethodZ()
        {
            await Task.Delay(3000);
        }
    }
}
