using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo12
{
    public class Person
    {
        //public int Id { get; set; }
        //public string Name { get; set; }

        public int MobileNumber { get; set; }

        public string Adress { get; set; }



        private int Id;
        private string Name;


        //public Person(int id, string name)
        //{
        //    this.Id = id;
        //    this.Name = name;

        //}

        //private string Address;

        public int id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { this.Name = value; }
        }

        

    }
}
