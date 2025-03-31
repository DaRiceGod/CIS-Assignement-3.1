using Microsoft.AspNetCore.Mvc;
using MyDotNetCoreMVC.Models;

namespace MyDotNetCoreMVC.Controllers
{
    public class IdentityController : Controller
    {
        private bool v1;
        private string v2;
        private string v3;
        private People p;


        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetJson()
        {
            List<Identity> result = new List<Identity>();

            Identity defaultidentity = new Identity();
            
            Random rng = new Random();
            People p = new("John Smith", rng.Next());
            Identity createdIdentity = new(true, "IT", "Manager", p);
            People r = new();
            r.Name = "Jane Doe";
            r.ID = 1;
            Identity updatedIdentity = new(true, "Executive", "CEO", r);
            result.Add(defaultidentity);
            result.Add(createdIdentity);
            result.Add(updatedIdentity);




            return Json(result);
        }
    }
}
