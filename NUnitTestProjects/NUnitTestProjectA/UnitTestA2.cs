using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestProjectA
{
    [Parallelizable(ParallelScope.All)]
    public class UnitTestA2
    {
        [Test]
        public async Task TestA2_1()
        {
            await Task.Delay(3000);
        }
    }
}
