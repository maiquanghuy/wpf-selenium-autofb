using AutoFB.Action;

namespace AutoFB.Model
{
    public class LikePostModel
    {
        public string [] UrlPost { get; set; }
        public FbAction action { get; set; }

        public LikePostModel(FbAction _action, string [] _url)
        {
            action = _action;
            UrlPost = _url;            
        }

        public void LikePost()
        {
            action.LikePost(UrlPost);
        }
    }
}
