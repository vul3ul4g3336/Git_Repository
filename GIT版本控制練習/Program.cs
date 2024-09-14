using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIT版本控制練習.Models;
using GIT版本控制練習.Services;

namespace GIT版本控制練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入帳號：");
            String account = Console.ReadLine();
            Console.WriteLine("請輸入密碼：");
            String password = Console.ReadLine();

            Login login = new Login();


            RegistModel registModel = new RegistModel(account, password);
            RegisterService service = new RegisterService();
            bool isSuccess =  service.UserRegist(registModel);
            if (isSuccess)
            {
                Console.WriteLine("註冊成功");
            }
            else
            {
                Console.WriteLine("註冊失敗");
            }
            login.LoginInto();
        }
    }
}
