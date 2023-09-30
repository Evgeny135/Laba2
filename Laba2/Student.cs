using System;

namespace Laba2
{
    public class Student
    {
        private int ID;
        private string LastName ;
        private string FirstName ;
        private string MiddleName ;
        private DateTime DateOfBirth ;
        private string Address ;
        private string PhoneNumber;

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string LastName1
        {
            get => LastName;
            set => LastName = value;
        }

        public string FirstName1
        {
            get => FirstName;
            set => FirstName = value;
        }

        public string MiddleName1
        {
            get => MiddleName;
            set => MiddleName = value;
        }

        public DateTime DateOfBirth1
        {
            get => DateOfBirth;
            set => DateOfBirth = value;
        }

        public string Address1
        {
            get => Address;
            set => Address = value;
        }

        public string PhoneNumber1
        {
            get => PhoneNumber;
            set => PhoneNumber = value;
        }

        public Student(int id, string lastName, string firstName, string middleName, DateTime DateOfBirth, string Address, string phoneNumber)
        {
            ID = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            PhoneNumber = phoneNumber;
        }

        public Student(int id, string lastName, string firstName, DateTime dateOfBirth, string address, string phoneNumber)
        {
            ID = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
        }


        public override string ToString()
        {
            return $"Студент ID={ID},LastName={LastName},FirstName= {FirstName}, MiddleName={MiddleName}, Date={DateOfBirth}, Address={Address}, Phone={PhoneNumber}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}