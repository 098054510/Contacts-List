using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_List
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public Person(int ID, string Name, int Number)
        {
            this.ID = ID;
            this.Name = Name;
            this.Number = Number;
        }

        public override string ToString()
        {
            return "ID: " + ID + "\n"
                + "Contact Name: " + Name + "\n"
                + "Number: " + Number;
        }
    }
}
