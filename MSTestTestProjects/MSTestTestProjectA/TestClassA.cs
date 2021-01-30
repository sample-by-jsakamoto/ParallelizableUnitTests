using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestProjectA
{
    [TestClass]
    public class TestClassA
    {
        [DataTestMethod]
        [DataRow("Alice")]
        [DataRow("Bob")]
        public async Task TestMethodX(string _)
        {
            await Task.Delay(3000);
        }

        [TestMethod]
        public async Task TestMethodY()
        {
            await Task.Delay(3000);
        }
    }
}
