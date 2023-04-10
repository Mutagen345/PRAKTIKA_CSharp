using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication45
{

    struct student
    {
        public string _fam;
        public string _name;
        public string _otch;
        public student(string fam, string name, string otch)
        {
            _fam = fam;
            _name = name;
            _otch = otch;
        }
    }
    class StudentGroup
    {
        string group_name;
        List<student> students;

        public StudentGroup(string groupName)
        {
            group_name = groupName;
            students = new List<student>();
        }

        public void AddStudent(student newStudent)
        {
            students.Add(newStudent);
        }

        public string GroupName
        {
            get { return group_name; }
            set { group_name = value; }
        }

        public void RemoveStudent(int index)
        {
            if (index >= students.Count)
                throw new Exception("Студента с таким индексом не существует.");
            students.RemoveAt(index);
        }

        public void ShowGroup()
        {
            for (int i = 0; i < students.Count; i++)
                Console.WriteLine("ФИО: " + students[i]._fam + " " + students[i]._name + " " + students[i]._otch);
        }
        public student FindStudent(string key)
        {
            for (int i = 0; i < students.Count; i++)
                if (students[i]._fam == key || students[i]._name == key || students[i]._otch == key)
                    return students[i];
            return new student("", "", "");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            StudentGroup group = new StudentGroup("32 программисты");
            student st = new student("Иванов", "Иван", "Иванович");
            for (int i = 0; i < 10; i++)
                group.AddStudent(st);
            student s = new student("Сидоров", "Сидр", "Сидорович");
            group.AddStudent(s);
            group.ShowGroup();
            student s_find = group.FindStudent("Сидоров");
            Console.WriteLine("Найденный студент: " + s._name);
            Console.WriteLine("Название группы:" + group.GroupName);
            Console.ReadKey();
        }
    }
}