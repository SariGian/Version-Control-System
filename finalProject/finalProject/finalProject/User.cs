using FinalProject.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class User: IReviewer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        public void Update()
        {
           //send email 
        }
    }

}
