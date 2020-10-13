using System;

namespace Model
{
    public class Activity
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
        public DateTime endTime { get; set; }
        public string activityPicture { get; set; }
        public string activityIntroduction { get; set; }
        public string summary { get; set; }
        public string activityVerify { get; set; }
        public string activityStatus { get; set; }
        public string userName { get; set; }
        public string recommend { get; set; }
        public DateTime recommendTime { get; set; }
    }
    public class workInfo
    {
        public int workId { get; set; }
        public string workName{ get; set; }
        public string WorkPicture { get; set; }
        public DateTime UploadTime { get; set; }
        public string WorkIntroduction { get; set; }
        public string WorkVerify { get; set; }
        public int ActivityId { get; set; }
        public string Recommend { get; set; }
        public DateTime recommendTime { get; set; }
    }
    public class Comment
    {
        public int commentId { get; set; }
        public int workId { get; set; }
        public string userName { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentTime { get; set; }
    }
    public class UserInfo
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public string qq { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string userImg { get; set; }
    }
    public class UserInfoNo : UserInfo
    {
        public int num { get; set; }
    }
    public class Page
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
    public class WorkFindPage:Page
    {
        public string workName { get; set; }
    }
    public class WorkMyPage:Page
    {
        public string userName { get; set; }
    }
    public class CommentPage:Page
    {
        public string workId { get; set; }
    }
    public class ActivityNo:Activity
    {
        public int num { get; set; }
    }

    public class ActivityName
    {
        public int activityId { get; set; }
    }
    public class WorkInfoNo:workInfo
    {
        public int num { get; set; }
        public string activityName { get; set; }
    }
    public class CommentNo:Comment
    {
        public int num { get; set; }
        public string workName { get; set; }
    }
}
