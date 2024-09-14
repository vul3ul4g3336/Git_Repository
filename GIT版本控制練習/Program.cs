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
            Console.WriteLine("XXXXXX登入系統");
            Console.WriteLine("請輸入使用者姓名：");
            String UserName = Console.ReadLine();
            Console.WriteLine("請輸入使用者帳號：");
            String Account = Console.ReadLine();
            Console.WriteLine("請輸入使用者密碼：");
            String Password = Console.ReadLine();
            Console.WriteLine("請輸入使用者地址：");
            String Address = Console.ReadLine();
            Console.WriteLine("AAAAAAAA");
            Console.WriteLine("BBBBBBBB");
            Console.WriteLine("CCCCCCCC");
            Console.WriteLine("AAAAAAAA");
            Console.WriteLine("BBBBBBBB");
            Console.WriteLine("CCCCCCCC");
            Console.WriteLine("AAAAAAAA");
            Console.WriteLine("BBBBBBBB");
            Console.WriteLine("CCCCCCCC");
            Console.WriteLine("AAAAAAAA");
            Console.WriteLine("BBBBBBBB");
            Console.WriteLine("CCCCCCCC");
            RegistModel user = new RegistModel(UserName, Account, Password, Address);
            RegisterService service = new RegisterService();

            if (service.UserRegist(user))
                Console.WriteLine("登入成功");
            else
            {
                Console.WriteLine("登入失敗");
            }
            Login login = new Login();

            login.LoginInto();
        }
    }
}
