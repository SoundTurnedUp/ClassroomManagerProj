using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagerProj
{
    public class Student
    {
        private string Name;
        private int Age;
        private string Address;

        public Student(string theName, int theAge, string theAddress)
        {
            Name = theName;
            Age = theAge;
            Address = theAddress;
        }
        public string GetName() { return Name; }
        public int GetAge() { return Age; }
        public string GetAddress() { return Address; }
    }
}
