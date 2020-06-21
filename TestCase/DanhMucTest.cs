using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe;

namespace TestCase
{
    [TestClass]
    public class DanhMucTest
    {
        fDanhMuc f = new fDanhMuc();
        /*
         55 cafe
         56 sinh to
         57 tra
             */
        [TestMethod]
        public void addTrue()
        {
            bool result = f.addDanhMucToDatabase("Nước ép");
            Assert.AreEqual(result, true);
        }
        /*
        55 cafe
        56 sinh to
        57 tra
        60 nuoc ep
            */
        [TestMethod]
        public void addNull()
        {
            bool result = f.addDanhMucToDatabase(" ");
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void addExist()
        {
            bool result = f.addDanhMucToDatabase("Nước ép");
            Assert.AreEqual(result, false);
        }   
        /*
        55 cafe
        56 sinh to
        57 tra
        60 nuoc ep
        */
        [TestMethod]
        public void updateDMTrue()
        {
            bool result = f.updateDanhMucInDatabase(60,"Soda");
            Assert.AreEqual(result, true);
        }
        /*
       55 cafe
       56 sinh to
       57 tra
       60 soda
       */
        [TestMethod]
        public void updateDMNull()
        {
            bool result = f.addDanhMucToDatabase(" ");
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void updateDMFalse()
        {
            bool result = f.updateDanhMucInDatabase(60, "Soda");
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void deleteDM()
        {
            bool result = f.deleteDanhMucInDatabase(60);
            Assert.AreEqual(result, true);
        }
        /*
            55 cafe
            56 sinh to
            57 tra
        */

    }
}
