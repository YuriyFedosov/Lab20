using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        /*
        В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
        - метод получает входным параметром переменную типа double;
        - метод возвращает значение типа double, которое является результатом вычисления.

        Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        -       длину окружности по формуле D = 2 * π* R;
        -       площадь круга по формуле S = π* R²;
        -       объем шара. Формула V = 4/3 * π * R³.

        Методы должны быть объявлены как статические*/
        
        delegate double CalcVer(double r); //Создание делегата
        
        static void Main(string[] args)
        {

            Console.WriteLine("Расчет параметров по введенному радиусу");
            Console.Write("\nВведите радиус для расчета: ");
            double rad = Convert.ToDouble(Console.ReadLine()); 
            double rez1, rez2, rez3;

            CalcVer calcVer = new CalcVer(RoundLength); //Создание экземпляра делегата с присвоением метода
            rez1 = calcVer(rad);
            calcVer = new CalcVer(RoundSqr); //Переприсвоение метода
            rez2 = calcVer(rad);
            calcVer = new CalcVer(RoundVol); //Переприсвоение метода
            rez3 = calcVer(rad);
            
            //Вывод результатов
            Console.WriteLine($"Длина окружности: {rez1:f2} \nПлощадь круга: {rez2:f2} \nОбъем шара: {rez3:f2}");
            Console.ReadKey();
        }
        //Методы для задачи
        static double RoundLength(double perRad)
        {
            return 2*Math.PI*perRad;
        }
        static double RoundSqr(double perRad)
        {
            return Math.PI * Math.Pow(perRad,2);
        }
        static double RoundVol(double perRad)
        {
            return 4/3 * Math.PI * Math.Pow(perRad,3);
        }
    }
   
}
