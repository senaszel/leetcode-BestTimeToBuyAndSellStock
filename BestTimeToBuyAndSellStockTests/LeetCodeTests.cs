using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestTimeToBuyAndSellStock.Tests
{
    [TestClass()]
    public class LeetCodeTests
    {
        [DataTestMethod()]
        [DataRow(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        public void MaxProfitTest_ShouldReturnExpectedOutcome(int[] prices, int output)
        {
            int actual = LeetCode.MaxProfit(prices);
            Assert.AreEqual(output, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitTest_ShouldReturn_0_WhenPricesDecrease(int[] prices, int output)
        {
            int actual = LeetCode.MaxProfit(prices);
            Assert.AreEqual(output, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] { 2, 4, 1 }, 2)]
        public void MaxProfitTest_ShouldNOT_TakeInAccountBoughtPossibilitesThatComeTooLate(int[] prices, int output)
        {
            int actual = LeetCode.MaxProfit(prices);
            Assert.AreEqual(output, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] { 2, 1, 2, 1, 0, 1, 2 }, 2)]
        public void MaxProfitTest_ShouldReturn_2_CosApparentlyItIsPossibleToBuyFor0(int[] prices, int output)
        {
            int actual = LeetCode.MaxProfit(prices);
            Assert.AreEqual(output, actual);
        }


        [DataTestMethod()]
        [DataRow(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 },4)]
        public void MaxProfitTest_ShouldReturn_4(int[] prices, int output)
        {
            int actual = LeetCode.MaxProfit(prices);
            Assert.AreEqual(output, actual);
        }
    }
}