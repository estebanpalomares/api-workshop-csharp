using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.rest.dto
{
    internal class BodyExample
    {
        private string name { set; get; }
        private string lastName { get; set; }
        private int age { set; get; }

        public string Name{ get { return name; } set { name = value; } }
        public string LastName { get { return lastName;} set { lastName = value; } }
        public int Age { get { return age;} set {age= value;} }
    }
}
