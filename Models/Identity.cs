using System.Runtime.Serialization;

namespace MyDotNetCoreMVC.Models
{
    public class Identity
    {
        public bool isActive { get; set; }
        public string Group { get; set; }
        public string Role { get; set; }
        
        public People Person { get; set; }
        public List<Permissions>  Perms { get; set;}





        public Identity()
        {
            isActive = false;
            Group = "None";
            Role = "None";
            Person = new People();
            Person.Name = "None";
            Person.ID = 0;
            List<Permissions> p = new List<Permissions>();
            Perms = p;
        }

        public Identity(bool active,  string group, string role, People person)
        {
            isActive = active;
            Group = group;
            Role = role;
            Person = person;
            //permissions.tags = { "Tag 1", "Tag 2", "Tag 3"};
            List<Permissions> p = new List<Permissions>();
            Perms = p;
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

    public class Permissions
    {
        [DataMember]
        public List<string> tags { get; set; }
        public Permissions() 
        {
            tags = new List<string>{ "Tag 1", "Tag 2"};
        }
    }
}
