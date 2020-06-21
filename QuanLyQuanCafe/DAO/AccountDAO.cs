using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { AccountDAO.instance = value; }
        }

        public AccountDAO() { }
        public List<Account> Account()
        {
            List<Account> listAccount = new List<Account>();
            string query = "EXEC AllUsers";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }
            return listAccount;
        }

        public bool Login(string tenTaiKhoan, string passWord)
        {
            string query = "Login @tenTaiKhoan , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[]{tenTaiKhoan,passWord});
            return result.Rows.Count > 0;
        }
        public int countAcc()
        {
            string query = "Select * from dbo.Account";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int a = result.Rows.Count;
            return a;
        }
        public Account AccountByUser(string tenTaiKhoan)
        {
            string query = "UserSearch @Username ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{tenTaiKhoan});
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string tenTaiKhoan,string tenHienThi,string passWord,string newPass)
        {
            string query = "EXEC UpdateAccount @tenTaiKhoan , @tenHienThi , @passWord , @newPassWord ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { tenTaiKhoan, tenHienThi,
                                                                                    passWord, newPass });
            return result > 0;
        }

        public bool InsertAccount(string tenTaiKhoan, string tenHienThi, int type)
        {
            string query = "InsertAccount @tenTaiKhoan , @tenHienThi , @type" ;
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTaiKhoan, tenHienThi
                                                                                    , type });

            return result > 0;
        }
        public bool UpdateListAccount(int id,string tenTaiKhoan, string tenHienThi,string pass, int type)
        {
            string query = "UpdateListAccount @id , @tenTaiKhoan , @tenHienThi , @pass , @type";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, tenTaiKhoan,
                                                                                    tenHienThi, pass, type});
        
            return result > 0;
        }
        public bool DeleteAccount(int id)
        {
            string query = "DeleteAccount @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] {id});

            return result > 0;
        }
    }
}
