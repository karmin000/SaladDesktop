using System;
using System.Collections.Generic;


namespace SaladDesktop
{

    
  

    class Program
    {
        public static void Main(string[] args)
        {

            var Vegetable1 = new Solanum();
            Vegetable1.SetName("Паслён");
            Vegetable1.SetColor("Чёрный");
            Vegetable1.SetCalories(100);
            Vegetable1.SetRootLength("90 сантиметров");

            var Vegetable2 = new Solanum();
            Vegetable2.SetName("Паслён");
            Vegetable2.SetColor("Чёрный");
            Vegetable2.SetCalories(140);
            Vegetable2.SetRootLength("90 сантиметров");

            var Vegetable3 = new Solanum();
            Vegetable3.SetName("Паслён");
            Vegetable3.SetColor("Чёрный");
            Vegetable3.SetCalories(110);
            Vegetable3.SetRootLength("90 сантиметров");

            var Vegetable4 = new Potato();
            Vegetable4.SetName("Картофель");
            Vegetable4.SetColor("Жёлтый");
            Vegetable4.SetCalories(116);
            Vegetable4.SetRootLength("25 сантиметров");
            Vegetable4.SetTypeOfPotato("Импала");

            var Vegetable5 = new Beet();
            Vegetable5.SetName("Свекла");
            Vegetable5.SetColor("Красный");
            Vegetable5.SetCalories(50);
            Vegetable5.SetDiametr(15);

            var Vegetable6 = new Potato();
            Vegetable6.SetName("Картофель");
            Vegetable6.SetColor("Розовый");
            Vegetable6.SetCalories(116);
            Vegetable6.SetRootLength("25 сантиметров");
            Vegetable6.SetTypeOfPotato("Ред Скарлет");

            var listObject = new ClassSalad();
            listObject.vegetableList.Add(Vegetable1);
            listObject.vegetableList.Add(Vegetable3);
            listObject.vegetableList.Add(Vegetable4);
            listObject.vegetableList.Add(Vegetable5);
            listObject.vegetableList.Add(Vegetable6);

            listObject.Show();
            listObject.TotalCalories();
            Console.ReadKey();

        }
    }
}
