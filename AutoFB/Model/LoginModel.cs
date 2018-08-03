using AutoFB.Action;

namespace AutoFB.Model
{
    public class LoginModel
    {
        public string email { get; set; }
        public string pass { get; set; }      
        public FbAction action { get; set; }

        public LoginModel(FbAction _action, string _email, string _pass)
        {
            action = _action;
            email = _email;
            pass = _pass;
        }

        public void DoProcess()
        {
            action.Login(email, pass);
        }
    }
}
