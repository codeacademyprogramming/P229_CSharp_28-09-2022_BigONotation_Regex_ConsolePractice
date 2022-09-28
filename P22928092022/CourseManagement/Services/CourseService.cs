using CourseManagement.Enums;
using CourseManagement.Interfaces;
using CourseManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.Services
{
    class CourseService : ICourseService
    {
        Group[] _groups;

        public CourseService()
        {
            _groups = new Group[0];
        }

        public Group[] Groups => _groups;

        public void AddGroup(byte limit, GroupType groupType)
        {
            Group group = new Group(limit, groupType);

            Array.Resize(ref _groups, _groups.Length + 1);
            _groups[_groups.Length - 1] = group;
        }

        public void AddStudent(string name, string surname, byte age, StudentType studentType, string groupNo)
        {
            foreach (Group group in _groups)
            {
                if (group.No == groupNo.ToUpper())
                {
                    if (group.Limit > group.Students.Length)
                    {
                        Student student = new Student(name, surname, age, groupNo, studentType);

                        Array.Resize(ref group.Students, group.Students.Length + 1);
                        group.Students[group.Students.Length - 1] = student;
                    }
                    else
                    {
                        Console.WriteLine($"{group.No} Qrupda Yer Yoxdur");
                    }
                }
            }
        }

        public bool CheckGroupByNo(string no)
        {
            foreach (var item in _groups)
                if (item.No == no.ToUpper())
                    return true;

            return false;
        }
    }
}
