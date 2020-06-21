using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe;

namespace TestCase
{
    [TestClass]
    public class AccountTest
    {
        fThongTinTaiKhoan f = new fThongTinTaiKhoan();
        fLogin fL = new fLogin();
        ChangePassWord cp = new ChangePassWord();
        [TestMethod]
        public void AddRong()
        {
            bool result = f.AddAccToDatabase("", "", 1);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void AddTrung()
        {
            bool result = f.AddAccToDatabase("Admin","Admin",1);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void AddDung()
        {
            bool result = f.AddAccToDatabase("Test", "Test", 1);
            Assert.AreEqual(result, true);
        }

        /* id taikhoan  hienthi pass type 
         * 1  admin     admin    1     1
          19  testing   test     0     1 */ 
        [TestMethod]
        public void UpdateRong()
        {
            bool result = f.updateAccInDatabase(19,"","","1",1);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void UpdateTrung()
        {
            bool result = f.updateAccInDatabase(19, "Admin", "Testing", "1", 1);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void UpdateDung()
        {
            bool result = f.updateAccInDatabase(19, "Tested", "Tested", "0", 1);
            Assert.AreEqual(result, true);
        }
        /* id taikhoan  hienthi pass type 
         * 1  admin     admin    1     1
          19  tested    tested   1     1 */
        [TestMethod]
        public void DeleteAccout()
        {
            f.DeleteAccount(19);
            int a = f.countAccount();
            Assert.AreEqual(1,a);
        }
        [TestMethod]
        public void LoginTrue()
        {
            bool result = fL.CheckLogin("Admin", "1");
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void LoginFalse()
        {
            bool result = fL.CheckLogin("Admin", "0");
            Assert.AreEqual(result, false);
        }
        /* id taikhoan  hienthi pass type 
         1  admin     admin    1     1 */
        [TestMethod]
        public void ChangeAccountTrue()
        {
            bool result = cp.UpdateAccount("admin", "admin", "1", "2", "2");
            Assert.AreEqual(result, true);
        }
        /* id taikhoan  hienthi pass type 
            1 admin     admin    2     1 */
        [TestMethod]
        public void ChangeAccountFalse()
        {
            bool result = cp.UpdateAccount("admin", "admin", "1", "2", "1");
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void ChangeAccountEmpty()
        {
            bool result = cp.UpdateAccount("admin1", "admin", "1", "2", "2");
            Assert.AreEqual(result, false);
        }
    }
}
