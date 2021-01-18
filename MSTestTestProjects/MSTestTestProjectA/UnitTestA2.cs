using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestProjectA
{
    [TestClass]
    public class UnitTestA2
    {
        [TestMethod]
        public async Task TestA2_1()
        {
            await Task.Delay(3000);
        }
    }
}
