using AutoFB.Action;

namespace AutoFB.Model
{
    class PostStatusModel
    {        
        public string[] StatusContent { get; set; }        
        public FbAction action { get; set; }

        public PostStatusModel(FbAction _action, string[] _content)
        {
            action = _action;            
            StatusContent = _content;
        }

        public void PostStatus()
        {
            action.PostStatus(StatusContent);
        }
    }
}
