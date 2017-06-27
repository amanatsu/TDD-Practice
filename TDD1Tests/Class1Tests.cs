using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD1.Tests
{
    public class 課題1
    {
        [TestClass()]
        public class ClosedRangeTests
        {
            [TestMethod()]
            [TestCategory("1-1下端点")]
            public void _3と8の場合3()
            {
                ClosedRange range = new ClosedRange(3, 8);
                int actual = range.getLowerEndpoint(); // => 3

                Assert.AreEqual(3, actual);
            }


            [TestMethod()]
            [TestCategory("1-1下端点")]
            public void _8と8の場合8()
            {
                ClosedRange range = new ClosedRange(8, 8);
                int actual = range.getLowerEndpoint(); // => 8

                Assert.AreEqual(8, actual);
            }

            [TestMethod()]
            [TestCategory("1-1上端点")]
            public void _3と8の場合8()
            {
                ClosedRange range = new ClosedRange(3, 8);
                int actual = range.getUpperEndpoint(); // => 8

                Assert.AreEqual(8, actual);
            }

            [TestMethod()]
            [TestCategory("1-1上端点")]
            public void _2と2の場合2()
            {
                ClosedRange range = new ClosedRange(2, 2);
                int actual = range.getUpperEndpoint(); // => 2

                Assert.AreEqual(2, actual);
            }
        }
    }
    public class 課題2
    {
        [TestClass()]
        public class ClosedRangeTests2
        {
            ClosedRange range38 = null;
            [TestInitialize]
            public void TestInitialize()
            {
                range38 = new ClosedRange(3, 8);
            }
            [TestMethod()]
            [TestCategory("1-2文字列")]
            public void _3と8の場合()
            {
                string actual = range38.toString(); // => "[3,8]"
                Assert.AreEqual("[3,8]", actual);
            }

            [TestMethod()]
            [TestCategory("1-3エラー")]
            [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
            public void _8と7の場合8()
            {
                ClosedRange range = new ClosedRange(8, 7);
            }

            [TestMethod()]
            [TestCategory("1-4帰属")]
            public void _3から8に2が含まれない()
            {
                Assert.IsFalse(range38.contains(2));
            }

            [TestMethod()]
            [TestCategory("1-4帰属")]
            public void _3から8に3が含まれるか()
            {
                Assert.IsTrue(range38.contains(3));
            }


            [TestMethod()]
            [TestCategory("1-4帰属")]
            public void _3から8に5が含まれるか()
            {
                Assert.IsTrue(range38.contains(5));
            }

            [TestMethod()]
            [TestCategory("1-4帰属")]
            public void _3から8に8が含まれるか()
            {
                Assert.IsTrue(range38.contains(8));
            }

            [TestMethod()]
            [TestCategory("1-4帰属")]
            public void _3から8に9が含まれない()
            {
                Assert.IsFalse(range38.contains(9));
            }

            [TestMethod()]
            [TestCategory("1-5等価性")]
            public void _3と8と等価()
            {
                Assert.IsTrue(range38.equals(new ClosedRange(3, 8)));
            }

            [TestMethod()]
            [TestCategory("1-5等価性")]
            public void _3と8と等価でない()
            {
                Assert.IsFalse(range38.equals(new ClosedRange(5, 10)));
            }

            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に4から6が含まれる()
            {
                Assert.IsTrue(range38.contains(new ClosedRange(4, 6)));
            }

            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に3から3が含まれる()
            {
                Assert.IsTrue(range38.contains(new ClosedRange(3, 3)));
            }


            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に8から8が含まれる()
            {
                Assert.IsTrue(range38.contains(new ClosedRange(8, 8)));
            }

            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に1から2が含まれない()
            {
                Assert.IsFalse(range38.contains(new ClosedRange(1, 2)));
            }

            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に9から10が含まれない()
            {
                Assert.IsFalse(range38.contains(new ClosedRange(9, 10)));
            }

            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に1から5が含まれない()
            {
                Assert.IsFalse(range38.contains(new ClosedRange(1, 5)));
            }

            [TestMethod()]
            [TestCategory("1-6包含")]
            public void _3から8に5から10が含まれない()
            {
                Assert.IsFalse(range38.contains(new ClosedRange(5, 10)));
            }
        }
    }
}