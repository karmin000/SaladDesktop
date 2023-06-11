using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladDesktop
{
    class ClassSalad
    {
        public List<Vegetable> vegetableList = new List<Vegetable>();
        internal static object listObject;

        public void ShowInfo(IPrint p)
        {
            p.Print();
        }
        public void Show()
        {
            foreach (IPrint p in vegetableList)
            {
                p.Print();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public double TotalCalories()
        {
            double totalCalories = 0;

            foreach (Vegetable p in vegetableList)
            {
                totalCalories += p.GetCalories();

            }
            return totalCalories;
        }

    }
}
