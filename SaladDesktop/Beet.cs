using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladDesktop
{
    class Beet : Vegetable, IPrint
    {
        private int _Diametr;
        public void SetDiametr(int diametr) { _Diametr = diametr; }
        public int GetDiametr() { return _Diametr; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Цвет: {GetColor()}");
            Console.WriteLine($"Калорийность: {GetCalories()}");
            Console.WriteLine($"Диаметр: {GetDiametr()}");

        }
    }
}
