using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectA
{
    public class TestClassB
    {
        [Fact]
        public async Task TestMethodZ()
        {
            await Task.Delay(3000);
        }
    }
}
