using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladDesktop
{
    class Vegetable: IPrint
    {
        private string _Name;
        private string _Color;
        private int _Calories;
        public void SetName(string name) { _Name = name; }
        public void SetColor(string color) { _Color = color; }
        public void SetCalories(int calories) { _Calories = calories; }
        public string GetName() { return _Name; }
        public int GetCalories() { return _Calories; }
        public string GetColor() { return _Color; }
        public void Print()
        {
            Console.WriteLine($"Имя: {_Name}");
            Console.WriteLine($"Цвет: {_Color}");
            Console.WriteLine($"Калории: {_Calories}");
        }
    }
}
