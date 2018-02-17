using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;

using RustToUnity;

namespace RustToUnity.Tests 
{
    [TestFixture]
    public class RustLibTests
    {

        [Test]
        public void TestMyRustFunc()
        {
            Assert.AreEqual(2.0f, MyRustFunc.Call(1.0f));
        }

        [Test]
        public void TestMyRustStruct()
        {
            var test = MyRustStruct.Create();
            Assert.AreEqual(1, test.i0);
            Assert.AreEqual(2, test.i1);
            Assert.AreEqual(1.0f, test.f0);
        }


    }
}
