using Webserver2.Models;



namespace Webserver2.Services
{
    public class VideoService : IVideoService
    {
        private static List<Video> videos = new List<Video>();


        public VideoService()
        {
            if (videos.Count == 0)
            {
                videos.Add(new Video() { Id = 1, Name = "bobby", Server = "localhost:7265", Last = "i know what you did last summer", LastDate = 22 });
                videos.Add(new Video() { Id = 2, Name = "alice", Server = "localhost33", Last = "i know 33", LastDate = 33 });
            }

        }

        public List<Video> Videos
        {
            get { return videos; }
        }
        public List<Video> GetAll()
        {
            //views=lastdate
            //description=last
            //title=name
            //server-new property

          


            //videos.Add(new Video() { Id = 2, Title = "foo2", Description = "Bar2", Views = 22 });
            // videos.Add(new Video() { Id = 3, Title = "foo2", Description = "Bar3", Views = 23 });
            return videos;



        }




        public Video Get(int id)
        {
            return videos.Find(x => x.Id == id);



        }

        public void Edit(int id, string uname, string server, string last, int lastdate)
        {

            Video video = Get(id);
            video.Name = uname;
            video.Last = last;
            video.Server = server;
            video.LastDate = lastdate;
        }


        public void Create(string uname, string last, string server, int lastdate)
        {
            int nextId = videos.Max(x => x.Id) + 1;
            videos.Add((new Video() { Id = nextId, Name = uname, Server = server, Last = last, LastDate = lastdate }));
            // return RedirectToAction("index");
        }



        public void Delete(int id)
        {
            Video video = videos.Find(video => video.Id == id);

            videos.Remove(Get(id));

        }


    }
}
