using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Билет_номер_1_по_ОАП
{
    internal class Program
    {
        
          
        static void Main(string[] args)
        {
            
            REG_MARK rEG_MARK = new REG_MARK();//Создаю объект класса чтобы можно было обращаться к созданному классу и его функциям 
            string Path = "C:\\Users\\Houme-PC\\OneDrive\\Рабочий стол\\Все билеты по экзамену ОАП\\1 билет\\test1.txt";//Указываю путь к файлу 
            string[] Mrk = File.ReadAllLines(Path);//Создали массив с типом данных стринг в него будут пемещенны все номера; Функция ReadAllLines Она просматривает файл и каждую строку файла помещает в отдельный объект массива 
            foreach(string mmrk  in Mrk)//Через Цикл Foreach перебираю массив чтобы можно было работать с каждым элементом массива 
            {
                Console.WriteLine(mmrk+ ": "+rEG_MARK.CheckMark(mmrk));//вывожу результат программы 
            }
            Console.ReadLine();
        }
    }
}
