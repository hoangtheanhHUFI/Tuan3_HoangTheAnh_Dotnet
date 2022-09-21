
using Microsoft.AspNetCore.Mvc;
using Tuan3_HoangTheAnh.Models;


namespace Tuan3_HoangTheAnh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            modelSach a = new modelSach("The Anh",30000, "/lib/image/img.jpg");
            modelSach b = new modelSach("Cuong thuan", 50000, "/lib/image/img.jpg");
            modelSach c = new modelSach("Chi tam", 35000, "/lib/image/img.jpg");
            modelSach d = new modelSach("The Anh", 63000, "/lib/image/img.jpg");
            modelSach e = new modelSach("The Anh", 30000, "/lib/image/img.jpg");
            modelSach f = new modelSach("The Anh", 30000, "/lib/image/img.jpg");
            modelSach g = new modelSach("The Anh", 30000, "/lib/image/img.jpg");


            List<modelSach> ds = new List<modelSach>();

            ds.Add(a); ds.Add(b); ds.Add(c); ds.Add(d); ds.Add(e); ds.Add(f); ds.Add(g);



            return View(ds);
        }
    }
}
