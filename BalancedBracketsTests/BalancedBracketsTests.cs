using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void OnlyOddBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }
        [TestMethod]
        public void EvenBracketsWithValue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Hello]"));
        }
        [TestMethod]
        public void OddBracketsWithValue()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[Hello]"));
        }
        [TestMethod]
        public void MisNestReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void EmptyBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void SingleBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void MisNestWithValueReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void MissingBracketwithValue()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        [TestMethod]
        public void BracketsWithinValue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void BarcketsBeforeValue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
    }
}
