using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectA
{
    public class UnitTestA2
    {
        [Fact]
        public async Task TestA2_1()
        {
            await Task.Delay(3000);
        }
    }
}
