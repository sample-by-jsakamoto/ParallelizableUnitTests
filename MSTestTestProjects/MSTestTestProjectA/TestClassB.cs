using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestProjectA
{
    [TestClass]
    public class TestClassB
    {
        [TestMethod]
        public async Task TestMethodZ()
        {
            await Task.Delay(3000);
        }
    }
}
