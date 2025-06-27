using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThu;

namespace TestSoNguyen
{
    public class TestSpService
    {
        SanPhamService sanPhamService;
        [SetUp]
        public void Setup()
        {
            sanPhamService = new SanPhamService();
        }
        [Test]
        public void TestDeleteNegative()
        {
            Assert.IsFalse(sanPhamService.Delete("-1"));
        }
        [Test]
        public void TestDeleteZero()
        {
            Assert.IsFalse(sanPhamService.Delete("0"));
        }
        [Test]
        public void TestDeleteOne()
        {
            Assert.IsTrue(sanPhamService.Delete("1"));
        }
        [Test]
        public void TestDeleteThree()
        {
            Assert.IsTrue(sanPhamService.Delete("3"));
        }
        [Test]
        public void TestDeleteFour()
        {
            Assert.IsFalse(sanPhamService.Delete("4"));
        }
    }
}
