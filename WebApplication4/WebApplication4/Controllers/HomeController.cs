using System.Web.Mvc;
using System.IO;
using WebApplication4.Models;
namespace WebApplication4.Controllers { 
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Edit()
        {
            if (System.IO.File.Exists("C:/index.txt"))
            {
                ViewBag.textFile = System.IO.File.ReadAllText("C:/index.txt");
            }
            return View();
       } 
         [HttpPost]
        public ViewResult Edit(FileModel fileModel)
        {
            string path = "C:/index.txt";
            System.IO.File.WriteAllText(path, fileModel.text);
            return View("Index", fileModel);
        }
     }
}
 
