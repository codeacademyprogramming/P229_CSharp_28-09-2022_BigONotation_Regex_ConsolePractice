using CourseManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.Models
{
    class Student
    {
        public string Name;
        public string SurName;
        public byte Age;

        public string GroupNo;
        public StudentType StudentType;

        public Student(string name, string surname, byte age, string groupNo, StudentType studentType)
        {
            Name = name;
            SurName = surname;
            Age = age;
            GroupNo = groupNo.ToUpper();
            StudentType = studentType;
        }

        public override string ToString()
        {
            return $"{Name} {SurName} {GroupNo}";
        }
    }
}
