using System;

namespace Client2.Models
{
    public class UserT
    {
        public string email {get; set;}
        public bool enabled {get; set;}
        public bool locked {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string gender {get; set;}
        public string password {get; set;}
        public string role  {get; set;}
    }
}
