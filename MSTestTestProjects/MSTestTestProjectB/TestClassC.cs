using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestTestProjectB
{
    [TestClass]
    public class TestClassC
    {
        [DataTestMethod]
        [DataRow("Alice")]
        [DataRow("Bob")]
        public async Task TestMethodW(string _)
        {
            await Task.Delay(3000);
        }
    }
}
