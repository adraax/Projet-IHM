using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project_VERON_MERLIN
{
    public class User
    {
        public int ID { get; }
        public string Name { get; }

        public User(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
