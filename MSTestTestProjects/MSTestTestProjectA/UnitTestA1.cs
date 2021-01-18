using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestProjectA
{
    [TestClass]
    public class UnitTestA1
    {
        [DataTestMethod]
        [DataRow("Alice")]
        [DataRow("Bob")]
        public async Task TestA1_1(string _)
        {
            await Task.Delay(3000);
        }

        [TestMethod]
        public async Task TestA1_2()
        {
            await Task.Delay(3000);
        }
    }
}
