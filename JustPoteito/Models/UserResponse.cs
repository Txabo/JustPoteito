using System.Xml;
using System;

namespace JustPoteito.Models
{
    public class UserResponse
    {
        public int id { get; set; }
        public string email { get; set; }

        public UserResponse() { }

        public UserResponse(int id, string email)
        {
            this.id = id;
            this.email = email;
        }
    }
}
