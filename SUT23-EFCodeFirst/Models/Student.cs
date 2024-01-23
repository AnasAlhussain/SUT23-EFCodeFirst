using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_EFCodeFirst.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public bool IsActiv { get; set; }
    }
}
