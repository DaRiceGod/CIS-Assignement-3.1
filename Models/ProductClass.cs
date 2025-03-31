using Microsoft.Win32;
using System.Runtime.Serialization;

namespace MyDotNetCoreMVC.Models
{
    public class ProductClass
    {
        public ProductClass(int id, string name, double price, string desc) 
        {
            this.Id = id;
            this.Name = name;
            this.Price = price; 
            this.ProdDescription = desc;
            //this.Reviews = list;
        }

        public ProductClass(int id, string name, double price, string desc, BaseReivew review)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.ProdDescription = desc;
            this.Reviews = new List<BaseReivew> { review };
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; }
        public string ProdDescription { get; set; }

        public List<BaseReivew> Reviews { get; set; }
        public List<Producer> Producers { get; set; }
    }

    public class BaseReivew
    {
        [DataMember]
        public int reviewRating { get; set; }
        public string reivewMessage { get; set; }

    }

    public class Producer
    {
        [DataMember]
        public string name { get; set; }
        public string company { get; set; }
        public int companyID { get; set; }
        public List<string> tags { get; set; }

    }
}
