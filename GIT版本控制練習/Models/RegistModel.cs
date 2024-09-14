using System;

namespace GIT版本控制練習.Models
{
    public class RegistModel
    {
        public String Account { get; set; }
        public String Password { get; set; }

        public RegistModel(String Account,String Password)
        {
            this.Account = Account;
            this.Password = Password;
        }
    }
}