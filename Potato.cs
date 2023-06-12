using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladDesktop
{
    class Potato : Solanum, IPrint
    {
        private string _TypeOfPotato;
        public void SetTypeOfPotato(string typeOfPotato) { _TypeOfPotato = typeOfPotato; }
        public string GetTypeOfPotato() { return _TypeOfPotato; }

        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Цвет: {GetColor()}");
            Console.WriteLine($"Калорийность: {GetCalories()}");
            Console.WriteLine($"Длина корня: {GetRootLength()}");
            Console.WriteLine($"Вид картофеля: {GetTypeOfPotato()}");
        }
    }
}
