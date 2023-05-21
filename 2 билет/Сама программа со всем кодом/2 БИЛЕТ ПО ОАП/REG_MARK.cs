using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_БИЛЕТ_ПО_ОАП
{
    public class REG_MARK
    {
        public bool CheckLogin(string login)
        {
            if (login.Length < 8)//Первое условие проверки логина, если он меньше 8 символов то программа сразу выдает False
            {
                return false;
            }
            if (login.Length >= 8)//Второе условие если логин больше 8 символов в длину то проверка идет дальше 
            {
                if (!char.IsDigit(login[0]))//Третье условие если первый сивол в логине не относится к категории десятичных цифр  то выдается true
                {
                    return true;
                }
            }
            return false;//В остальных случаях выдает false
        }
    }
}
