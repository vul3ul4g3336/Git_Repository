using System;

namespace GIT版本控制練習.Models
{
    public class RegistModel
    {
        public String Account { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }


        public RegistModel(String Name,String Account,String Password,String Address)
        {
            this.Name = Name;
            this.Address = Address;
            this.Account = Account;
            this.Password = Password;
        }
    }
}