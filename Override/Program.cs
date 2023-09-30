using System;
using System.Collections.Generic;
using Laba2;

namespace Override
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Group> GroupsList = new List<Group>();

            while (true)
            {
                Console.WriteLine("Выберите из списка:");
                Console.WriteLine("1. Создать группу");
                Console.WriteLine("2. Добавить студента в группу");
                Console.WriteLine("3. Удалить студента из группы");
                Console.WriteLine("4. Вывести информацию о группах");
                Console.WriteLine("5. Вывести информацию о студенте в группе");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите номер группы:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        GroupsList.Add(new Group(number));
                        break;
                    case "2":
                        Console.WriteLine("В какую группу добавить студента");
                        int numberGroup = Convert.ToInt32(Console.ReadLine());
                        Group group = null;
                        foreach (var gr in GroupsList)
                        {
                            if (gr.NumberGroup1==numberGroup)
                            {
                                group = gr;
                            }
                        }
                        Console.WriteLine("Введите номер зачетной книжки");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите фамилию студента");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Введите имя");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Введите отчество,или пустую строку если нет");
                        string middleName = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения в формате DD-MM-YYYY");
                        string[] d = Console.ReadLine().Split('-');
                        Console.WriteLine("Введите адрес");
                        string address = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона");
                        string numberPhone = Console.ReadLine();
                        group.AddStudent(new Student(id,lastName,firstName,middleName,new DateTime(Convert.ToInt32(d[2]),Convert.ToInt32(d[1]),Convert.ToInt32(d[0])),address
                            ,numberPhone));
                        break;
                    case "3":
                        Console.WriteLine("С какой группы удалить студента");
                        int numberGroup1 = Convert.ToInt32(Console.ReadLine());
                        Group group1 = null;
                        foreach (var gr in GroupsList)
                        {
                            if (gr.NumberGroup1==numberGroup1)
                            {
                                group1 = gr;
                            }
                        }
                        Console.WriteLine("Введите номер зачетной книжки");
                        int numId = Convert.ToInt32(Console.ReadLine());
                        group1.RemoveStudent(numId);
                        break;
                    case "4":
                        foreach (var gr in GroupsList)
                        {
                            gr.GetInfo();
                        }
                        break;
                    case "5":
                        Console.WriteLine("С какой группы посмотреть студента");
                        int numberGroup2 = Convert.ToInt32(Console.ReadLine());
                        Group group2 = null;
                        foreach (var gr in GroupsList)
                        {
                            if (gr.NumberGroup1==numberGroup2)
                            {
                                group2 = gr;
                            }
                        }
                        Console.WriteLine("Введите номер зачетной книжки студента");
                        int stud = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(group2[stud].ToString());
                        break;
                }
            }
        }
    }
}