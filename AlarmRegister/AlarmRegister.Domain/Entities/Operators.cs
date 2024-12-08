using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmRegister.Domain.Entities
{
    public class Operators
    {
        public string name { get; }
        public int ID { get; }
        public int Cell_contact { get; }
        public Operators(string name, int ID,int Cell_contact)
        {
            this.name = name;
            this.ID = ID;
            this.Cell_contact = Cell_contact;
        }

    }
}
