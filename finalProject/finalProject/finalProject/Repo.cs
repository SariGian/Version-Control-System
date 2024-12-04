using FinalProject.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Repo
    {
        public string Name { get; set; }
        public Branch Main { get; }
        public Repo(string name)
        {
            Name = name;
            Main = new("Main");
        }
       
    }
}
