using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билет_номер_1_по_ОАП
{
    public class REG_MARK
    {
        public bool CheckMark(string mark)
        {
            string[] regions = new string[] { "74", "01", "174", "02", "03", "04", "96", "196", "197" };//Создал массив с доступными регионами которые могут быть на номерах автомобилей в России
            List<char> chars = new List<char>() { 'Й', 'Ц', 'Г', 'Ш', 'Щ', 'З', 'Ъ', 'Ф', 'Ы', 'П', 'Л', 'Д', 'Ж', 'Э', 'Я', 'Ч', 'И', 'Ь', 'Б', 'Ю', 'Ё' };//Создали лист недопустимых букв в номере

            string nomer = mark.Substring(0, 6);//создаю переменную которая показывает с какого момента и какой длины будет номер 
            string regionNumber = mark.Substring(6);//создаю переменную которая показывает с какой момента будет начинаться регион

            foreach (char c in chars)//Через цикл перебираю лист недопустимых букв
            {
                if (nomer.Contains(c)) return false;//условие усли переменная nomer содержит недопустимые символы то выдается false
            }
            if (!regions.Contains(regionNumber)) return false;//если в массиве регионов не находится регион который указан в номере то программа выдаст false 

            return true;//то что будет выдаваться если не попадает под все условия
        }
    }
}
