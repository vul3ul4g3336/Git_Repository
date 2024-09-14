using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GIT版本控制練習.Services
{
    public class Login
    {
        public Dictionary<string, string> AccountNum = new Dictionary<string, string>();

        public void LoginInto()
        {
            Console.Write("請輸入帳號: ");
            string account = Console.ReadLine();
            Console.Write("請輸入密碼: ");
            bool LoginSuccess = IsPasswordCorrect(Console.ReadLine(), account);
            if (LoginSuccess)
            {
                Console.WriteLine("成功登入!");

            }
            else
                Console.WriteLine("登入失敗");
            return;
        }
        private bool IsPasswordCorrect(string password, string account)
        {
            if (password == AccountNum[account])
            {
                return true;
            }
            return false;
        }
    }
}
