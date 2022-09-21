
using Microsoft.AspNetCore.Mvc;
using Tuan3_HoangTheAnh.Models;


namespace Tuan3_HoangTheAnh.Controllers
{
    
    public class HomeController : Controller
    {
        static List<modelSach> ds = new List<modelSach>();
        public IActionResult Index()
        {
            modelSach a = new modelSach("1","The Anh",30000, "/lib/image/img.jpg");
            modelSach b = new modelSach("1", "Cuong thuan", 50000, "/lib/image/img.jpg");
            modelSach c = new modelSach("1", "Chi tam", 35000, "/lib/image/img.jpg");
            modelSach d = new modelSach("1", "The Anh 1", 63000, "/lib/image/img.jpg");
            modelSach e = new modelSach("1", "The Anh 2", 30000, "/lib/image/img.jpg");
            modelSach f = new modelSach("1", "The Anh 3", 30000, "/lib/image/img.jpg");
            modelSach g = new modelSach("1 ", "The Anh 4", 34000, "/lib/image/img.jpg");


            List<modelSach> ds = new List<modelSach>();

            ds.Add(a); ds.Add(b); ds.Add(c); ds.Add(d); ds.Add(e); ds.Add(f); ds.Add(g);



            return View(ds);
        }
        public ActionResult ChiTiet(string Id)
        {
            modelSach a = ds.FirstOrDefault(x => x.id.Equals(Id));
            return View(a);
        }
    }
}
