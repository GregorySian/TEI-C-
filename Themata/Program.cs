using System;
using System.Collections;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Themata
{
    partial class Program
    {
        public class Car
        {
            private string _model;
            private int _cc;
            private int _hp;

            public Car()
            {
                _model = null;
                _cc = 0;
                _hp = 0;
            }

            public Car(string model, int cc, int hp)
            {
                _model = model;
                _cc = cc;
                _hp = hp;
            }

            public void InputData()
            {
                Console.WriteLine("Enter the model: ");
                string _model = Console.ReadLine();
                Console.WriteLine("Enter the CC: ");
                int _cc = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the HP: ");
                int _hp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Model:{_model} cc:{_cc} hp: {_hp}");
            }

            public override string ToString()
            {
                return $"Model:{_model} cc:{_cc} hp: {_hp}";
            }
        }
    }
}
