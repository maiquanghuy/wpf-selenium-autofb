using System.Security.Cryptography;
using System.Text;

namespace AutoFB.Action
{
    class EncodeAction
    {
        //email login after MD5 hash
        public const string MD5_EMAIL = "4740B96AD981C3BEA28ADA44BE521CB7";
        //password after MD5 hash
        public const string MD5_PASSWORD = "3DFACFE8B11D8ECD7B9E20144D29DEE0";

        public static string EncodeData(string str)
        {
            //Create MD5 
            MD5 mh = MD5.Create();
            //Convert str to byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            //encode byte data
            byte[] hash = mh.ComputeHash(inputBytes);
            //create stringbuilder
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            str = sb.ToString();
            return str;
        }

        public static bool Login(string _email, string _pass)
        {
            if(MD5_EMAIL.Equals(EncodeData(_email)) && MD5_PASSWORD.Equals(EncodeData(_pass)))
            {
                return true;
            }
            return false;
        }
    }
}
