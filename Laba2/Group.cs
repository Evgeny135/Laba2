using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Laba2;

public class Group
{
    private int NumberGroup;
    private List<Student> StudentList = new List<Student>();

    public Group(int numberGroup)
    {
        NumberGroup = numberGroup;
    }

    public void AddStudent(Student student)
    {
        StudentList.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        StudentList.Remove(student);
    }

    public void RemoveStudent(int id)
    {
        for (int i = 0; i < StudentList.Capacity; i++)
        {
            if (StudentList[i].Id==id)
            {
                Student student = StudentList[i];
                StudentList.Remove(student);
                break;
            }
            
        }
    }

    public int NumberGroup1
    {
        get => NumberGroup;
        set => NumberGroup = value;
    }

    public Student this[int id]
    {
        get
        {
            foreach (var student in StudentList)
            {
                if (student.Id==id)
                {
                    return student;
                }
            }

            return null;
        }
    }
    

    public void GetInfo()
    {
        StudentList.Sort((student,student1)=>student.LastName1.CompareTo(student1.LastName1));
        Console.WriteLine(NumberGroup);
        foreach (var student in StudentList)
        {
            Console.WriteLine(student.ToString());
        }
    }
    
}