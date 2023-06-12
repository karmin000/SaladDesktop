using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladDesktop
{
    class Solanum : Vegetable, IPrint
    {
        private string _RootLength;
        public void SetRootLength(string rootLength) { _RootLength = rootLength; }
        public string GetRootLength() { return _RootLength; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Цвет: {GetColor()}");
            Console.WriteLine($"Калорийность: {GetCalories()}");
            Console.WriteLine($"Длина корня: {GetRootLength()}");
        }

    }
}
