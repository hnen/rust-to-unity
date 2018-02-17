using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vs_sln
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new RustToUnity.Tests.RustLibTests();
            test.TestMyRustStruct();
        }
    }
}
