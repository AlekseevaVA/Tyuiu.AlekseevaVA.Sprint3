using Tyuiu.AlekseevaVA.Sprint3.Task1.V23.Lib;

namespace Tyuiu.AlekseevaVA.Sprint3.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #3 | Выполнила: Алексеева В. А. | ИИПб-25-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while ,которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}

