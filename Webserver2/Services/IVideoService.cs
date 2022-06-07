using Webserver2.Models;

namespace Webserver2.Services
{
    public interface IVideoService
    {
        public List<Video> GetAll();
        public Video Get(int id);
        public void Edit(int id, string uname, string server, string last, int lastdate);
        public void Create(string uname, string last, string server, int lastdate);

        public void Delete(int id);

    }
}
