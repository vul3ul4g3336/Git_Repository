using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GIT版本控制練習.Services
{
    internal class Login
    {
        Dictionary<string,string> AccountNum= new Dictionary<string,string>();
        public Login() 
        {
            Console.Write("請輸入帳號: ");
            string account=Console.ReadLine();
            Console.Write("請輸入密碼: ");
            IsPasswordCorrect(Console.ReadLine(),account);

        }
        private bool IsPasswordCorrect(string password,string account)
        {
            if (password == AccountNum[account])
            {
                return true;
            }
            return false;
        }
    }
}
