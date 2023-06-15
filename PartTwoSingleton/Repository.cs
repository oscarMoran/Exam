using DataBaseManagement;
using DataBaseManagement.Models;
using System.Security.Cryptography;
using System.Text;

namespace PartTwoSingleton
{
    public class Repository
    {
        private readonly static Repository _instance = new();

        public static Repository Instance
        {
            get { return _instance; }
        }
        public Repository()
        {    
        }

        public List<Bank> GetBankList()
        {
            var objManagement = new DBManagement();
            return objManagement.GetBanks();
        }

        public User GetUser(string userName, string pwd)
        {
            var objManagement = new DBManagement();
            User user = objManagement.GetUser(userName);
            if (string.IsNullOrEmpty(user.UserName))
            {
                return null;
            }
            var pdwHashed = GetSha256(pwd);
            if(pdwHashed != user.Password)
            {
                return null;
            }
            return user;
        }



        private string GetSha256(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            SHA256 sha = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            StringBuilder sb = new StringBuilder();
            byte[] stream = sha.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }
    }
}