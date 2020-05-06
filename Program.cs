using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaCifer
{
    class Program
    {
        static void Main(string[] args)
        {
            string Vstr;            
            string R;
           // int iNp;
            int iSl; 
           // int iS;
            int SC;
            int iCs;
            char [] chVs;

            Console.Write("Введите любые символы: ");
            Vstr = Console.ReadLine();
           // iNp = 1;
            SC = 0;
            iSl = Vstr.Length;                    
            chVs = Vstr.ToCharArray();

            for (int i = 0; i < iSl; i++)
            {            
                 if (char.IsDigit(chVs[i]))
                 {
                   R = Vstr.Substring(i, 1);
                   iCs = Convert.ToInt32(R);
                   SC = SC+iCs;
                 }
            }
            Console.WriteLine("Сумма цифр из строки ровна: " + SC);
            Console.ReadLine();
        }
    }
}
