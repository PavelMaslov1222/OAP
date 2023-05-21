using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Подключил библиотеку для работы с текстовыми файлами 

namespace _2_БИЛЕТ_ПО_ОАП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Path = "C:\\Users\\Houme-PC\\OneDrive\\Рабочий стол\\test2.txt";//Путь к моему файлу на компьютере
            string[] loginss = File.ReadAllLines(Path);//Создал массив с именем loginss и спомощью функции ReadAllLines, которая находится в классе File, она каждую строку в файле делает как отдельный элемент массива

            REG_MARK rEG_MARK = new REG_MARK(); //Создал объект класса, чтобы у меня была возможность обращаться к созданному классу и его функциям 
            foreach (string log in loginss)//Перебираю через foreach свой массив чтобы иметь доступ к каждому элементу массива через переменную типа стринг log
            {
                Console.WriteLine(log +": " + rEG_MARK.CheckLogin(log));//Вывожу на консоль свою реализованную функцию, сначала выводится сам логин потом двоиточие и дальше идет уже результат, подходит ли логин под критерии
            }
            Console.ReadLine();//Закрепляю консоль 
        }
    }
}
