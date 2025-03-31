using System.Runtime.Serialization;

namespace MyDotNetCoreMVC.Models
{
    public class Identity
    {
        public bool isActive { get; set; }
        public string Group { get; set; }
        public string Role { get; set; }
        
        public People Person { get; set; }





        public Identity()
        {
            isActive = false;
            Group = "None";
            Role = "None";
            Person = new People();
            Person.Name = "None";
            Person.ID = 0;
        }

        public Identity(bool active,  string group, string role, People person)
        {
            isActive = active;
            Group = group;
            Role = role;
            Person = person;
        }

    }

    public class People
    {
        [DataMember]
        public string Name { get; set; }
        public int ID { get; set; }

        public People(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public People()
        {
            Name = "None";
            ID = 0;
        }
    }
}
