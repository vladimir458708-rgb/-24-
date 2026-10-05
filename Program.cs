using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свиридова_Анна_24_ИС
{
    internal class Program
    {
        class Car
        {
            public string marka;
            public string number;
            public int probeg;
            public void Show()
            {
                Console.WriteLine($"Автомобиль: Марка = {marka}, Гос.Номер = {number}, Пробег = {probeg} км");
            }
            public float AverageMileage(int age)
            {
            if (age <= 0)
            {
            return probeg;
            }
            return (float)probeg / age;
        }

    static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.marka = "Жигули";
            myCar.number = "T144T0";
            myCar.probeg = 10350;

            myCar.Show();

            int age = 2;
            float averageMileage = myCar.AverageMileage(age);
                Console.WriteLine($"Средний пробег для возарста {age} года состовляет: {averageMileage} км/год");

                Console.ReadKey();

        }
    }
   
    }
}
