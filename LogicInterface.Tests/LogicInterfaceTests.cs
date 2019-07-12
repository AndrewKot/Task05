using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicInterface.Tests
{
    [TestClass]
    public class LogicInterfaceTests
    {
        [TestMethod]
        public void GetBitStringOfDouble()
        {
            // arrange
            double input = 12.4;
            string expected = "0100000000101000110011001100110011001100110011001100110011001101";

            // act 
            string actual = TranslateToBinary.GetDoubleInBit(input);
            string actual2 = TranslateToBinary.GetDoubleInBit2(input);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual2);
        }
    }
}
