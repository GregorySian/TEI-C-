﻿using System;

namespace Themata3
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string aM;

        public Student()
        {

        }


        public Student(string fName, string lName, string am)
        {
            firstName = fName ;
            lastName = lName;
            aM = am;
        }

        public void InputData()
        {
            Console.WriteLine("Enter your First Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your AM");
            aM = Console.ReadLine();
            Console.WriteLine($"Onoma: {firstName} Epitheto: {lastName} AM: {aM}");
        }
        public override string ToString()
        {
            return $"Onoma: {firstName} Epitheto: {lastName} AM: {aM}";
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.InputData();
            Student s2 = new Student("Gregory ", "Sianopoulos " , "4414151");
            Console.WriteLine(s2);
        }
    }
}
