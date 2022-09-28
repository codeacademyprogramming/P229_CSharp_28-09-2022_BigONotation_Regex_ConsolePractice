using CourseManagement.Enums;
using CourseManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.Interfaces
{
    interface ICourseService
    {
        Group[] Groups { get; }
        void AddGroup(byte limit, GroupType groupType);
        void AddStudent(string name, string surname, byte age, StudentType studentType, string groupNo);
        bool CheckGroupByNo(string no);
    }
}
