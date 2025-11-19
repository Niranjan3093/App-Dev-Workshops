using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Student
    {
        public String name;
        public int age;
        public int id;
        public static String college = "Itahari International College";

        public Student(String name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
}
