using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThu;

namespace TestSoNguyen
{
    public class TestTing
    {
        SoNguyen soNguyen;
        [SetUp]
        public void Setup()
        {
            soNguyen = new SoNguyen();
        }
        [Test]
        public void TestWithNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => soNguyen.SoNguyenSum(-1));
        }
        [Test]
        public void TestWithZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => soNguyen.SoNguyenSum(-0));
        }

        [Test]
        public void TestWithOne()
        {
            Assert.AreEqual(1, soNguyen.SoNguyenSum(1));
        }

        [Test]
        public void TestWithTwo()
        {
            Assert.AreEqual(1, soNguyen.SoNguyenSum(2));
        }

        [Test]
        public void TestWithThree()
        {
            Assert.AreEqual(4, soNguyen.SoNguyenSum(3));
        }

    }
}
