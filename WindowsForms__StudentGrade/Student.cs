using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms__StudentGrade
{
    public class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public int Physics { get; set; }
        public int Math { get; set; }
        public int ComputerScience { get; set; }
        public DateTime ExamDate { get; set; }





        //public Student(string firstName, string lastName, string group, int physics, int math, int computerScience, DateTime examDate)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Group = group;
        //    Physics = physics;
        //    Math = math;
        //    ComputerScience = computerScience;
        //    ExamDate = examDate;
        //}

        public int CompareTo(object obj)
        {

            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }


        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName} {ExamDate.ToLongDateString(),-17}";
        //}
    }
}
