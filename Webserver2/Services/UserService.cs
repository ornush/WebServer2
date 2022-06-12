using Webserver2.Models;



namespace Webserver2.Services
{
    public class UserService : IUserService
    {
        private static List<User> videos = new List<User>();


        public UserService()
        {
            if (videos.Count == 0)
            {
                videos.Add(new User() { Id = 1, Name = "bobby", Server = "localhost:7265", Last = "i know what you did last summer", LastDate = 22 });
                videos.Add(new User() { Id = 2, Name = "alice", Server = "localhost33", Last = "i know 33", LastDate = 33 });
            }

        }

        public List<User> Videos
        {
            get { return videos; }
        }
        public List<User> GetAll()
        {
            //views=lastdate
            //description=last
            //title=name
            //server-new property


            //videos.Add(new Video() { Id = 2, Title = "foo2", Description = "Bar2", Views = 22 });
            // videos.Add(new Video() { Id = 3, Title = "foo2", Description = "Bar3", Views = 23 });
            return videos;



        }

        //get id for name
        public User Get(int id)
        {
            return videos.Find(x => x.Id == id);
        }


        //get last message 
        public string GetMsg(int id)
        {
            User video = Get(id);
            return video.Last;
            // return videos.Find(x => x.Id == id);
        }


        public void Edit(int id, string uname, string server, string last, int lastdate)
        {
            User video = Get(id);
            video.Name = "Charles";
            //    video.Last = last;
            video.Server = "localhost:7266";
            //  video.LastDate = lastdate;
        }

        public void Create(string uname, string last, string server, int lastdate)
        {
            // int nextId = videos.Max(x => x.Id) + 1;
            videos.Add((new User() { Id = 8, Name = "ch", Server = "ch", Last = "ch", LastDate = 8 }));
            // return RedirectToAction("index");
        }


        public void CreateMsg(int id, string uname, string server, string last, int lastdate)
        {

            User video = Get(id);
            // video.Name = "Charles";
            video.Last = video.Last + " " + ",this is a new message";

            //  video.Server = "localhost:7266";
            //  video.LastDate = lastdate;
        }


        public void Delete(int id)
        {
            User video = videos.Find(video => video.Id == id);

            videos.Remove(Get(id));

        }


    }
}
