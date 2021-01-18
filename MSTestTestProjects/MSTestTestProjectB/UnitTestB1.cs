using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestProjectB
{
    [TestClass]
    public class UnitTestB1
    {
        [DataTestMethod]
        [DataRow("Alice")]
        [DataRow("Bob")]
        public async Task TestB1_1(string _)
        {
            await Task.Delay(3000);
        }
    }
}
