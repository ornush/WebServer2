using Microsoft.AspNetCore.Mvc;
using Webserver2.Models;
using Webserver2.Services;

namespace Webserver2.Controllers
{


    [Route("api/[controller]")]

    [ApiController]
    public class ContactsController : Controller
    {
        // private static List<Video> videos = new List<Video>();
        private UserService service;

        public ContactsController()
        {
            service = new UserService();

            /* if (videos.Count == 0)
              {
                  videos.Add(new Video() { Id = 1, Title = "foo", Description = "Bar", Views = 2 });
                  videos.Add(new Video() { Id = 2, Title = "foo2", Description = "Bar2", Views = 22 });
                  videos.Add(new Video() { Id = 3, Title = "foo2", Description = "Bar3", Views = 23 });
              }*/
        }


        ///GET-.foo.com/api/contacts
        [HttpGet]
        public IActionResult Index()
        {
            //  return Json(service.Videos.ToArray());
            return Json(service.GetAll().ToArray());

            //  return View(service.GetAll());
        }




        //POST-.foo.com/api/contacts
        [HttpPost]
        [ActionName("Index")]

        public IActionResult Create(string uname, string last, string server, int lastdate)
        {
            service.Create(uname, last, server, lastdate);
            // HttpContext.Session.GetString("id");

            //HttpContext.Session.SetString("id",title);

            //int nextId = videos.Max(x => x.Id) + 1;
            // videos.Add(new Video() { Id = nextId, Title = title, Description = description });
            // return RedirectToAction("index");
            return Json(service.GetAll().ToArray());

        }


        //GET-  .foo.com/api/contacts/:id
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            // Video video = videos.Find(x => x.Id == id);
            // return View(service.Get(id));
            return Json(service.Get(id));

        }






        //PUT-  .foo.com/api/contacts/:id
        [HttpPut("{id}")]
        public IActionResult Edit(int id, string uname, string server, string last, int lastdate)
        {

            //  Video video = videos.Find(video => video.Id == id);
            //   video.Title = title;
            // video.Description = description;

            //   return RedirectToAction("index");
            service.Edit(id, uname, server, last, lastdate);

            return RedirectToAction("index");

        }


        public IActionResult Create(string id)
        {
            return View();
        }






        //  [HttpGet("{id}")]
        public IActionResult Edit(int  id)
        {
            //Video video = videos.Find(video => video.Id == id);
            return View(service.Get(id));

        }

     


        // [Route("api/[controller]/[action]")]

    //    [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            // Video video = videos.Find(video => video.Id == id);

            // return View(video);
            return View(service.Get(id));


        }

       

     //  [HttpPost]
      // [ActionName("Delete")]
        public IActionResult Delete1(int id)
        {

            // Video video = videos.Find(video => video.Id == id);

            // videos.Remove(video);
            // return RedirectToAction("index");

            service.Delete(id);
            return RedirectToAction("index");



        }


        



    }
}
