using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFour_Demo
{
    // create datatype called person [user defined datatype] and contain 3 parts id,name,age
    // id,name,age called Properties or property pattern
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Age = {Age}";
        }
    }
}
