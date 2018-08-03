using AutoFB.Action;

namespace AutoFB.Model
{
    class CommentModel
    {
        public string[] LinkPost { get; set; }
        public string CommentContent { get; set; }
        public FbAction action { get; set; }

        public CommentModel(FbAction _action, string[] _linkPost, string _comment)
        {
            action = _action;
            CommentContent = _comment;
            LinkPost = _linkPost;
        }

        public void PostComment()
        {
            action.PostComment(LinkPost,CommentContent);
        }
    }
}
