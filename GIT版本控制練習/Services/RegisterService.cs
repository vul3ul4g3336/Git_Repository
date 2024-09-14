using GIT版本控制練習.Models;

namespace GIT版本控制練習.Services
{
    public class RegisterService
    {
        public bool UserRegist(RegistModel model)
        {
            UserModel userModel = new UserModel();
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            return true;
        }
    }
}