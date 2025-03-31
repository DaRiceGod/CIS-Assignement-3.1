using Microsoft.AspNetCore.Mvc;
using MyDotNetCoreMVC.Models;

namespace MyDotNetCoreMVC.Controllers
{
    public class ProdController : Controller
    {

        [HttpGet]
        public JsonResult getResponse()
        {

            BaseReivew r1 = new BaseReivew();
            r1.reviewRating = 1;
            r1.reivewMessage = "Garbage product, terrible, do not purchase. I should have been paid to take it off their hands.";
            ProductClass product = new ProductClass(0, "Name", 0.00, "Description", r1);
            Producer producer = new Producer();
            producer.companyID = 0001;
            producer.name = "First Last";
            producer.company = "Company";
            producer.tags = new List<string> { "Tag 1", "Tag 2", "Tag 3" };
            product.Producers = new List<Producer> { producer };
            //product.Reviews = new List<BaseReivew> { r1 };
           // product.Reviews.Add(r1);



            

            return Json(product);
        }
    }
}
