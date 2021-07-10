using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quokka.TCL.Tools;

namespace Quokka.TCL.Tests
{
    [TestClass]
    public class TCLEscapingTests
    {
        [TestMethod]
        public void Empty()
        {
            Assert.AreEqual(null, TCLEscaping.Default.Escape(null));
            Assert.AreEqual("", TCLEscaping.Default.Escape(""));
        }

        [TestMethod]
        public void Same()
        {
            Assert.AreEqual("1aB9-_Z87", TCLEscaping.Default.Escape("1aB9-_Z87"));
        }

        [TestMethod]
        public void Escaped()
        {
            Assert.AreEqual("{hello world}", TCLEscaping.Default.Escape("hello world"));
        }

    }
}
