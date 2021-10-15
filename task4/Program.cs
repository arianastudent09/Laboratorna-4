using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program

    {
        static void Main(string[] args)
        {
         Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
         Console.WriteLine("Треба ввести номер ключа доступа (1 - Trial версія, 2 - Pro версія)");
         Console.WriteLine("Отримання Common версії при неправильному введені чи не введені номеру ключа доступу");
         string kod = Console.ReadLine();
         ApplicationLicense dos = new ApplicationLicense(kod);

        }
    }
    class ApplicationLicense
    {
        private static void AllowTrial()
        {
            Console.WriteLine("Trial версія");
        }
        private static void AllowCommon()
        {
            Console.WriteLine("Common версия");
        }
        private static void AllowPro()
        {
            Console.WriteLine("Pro версия");
        }
        public ApplicationLicense(string kod)
        {
            if (kod == "1")
            {
                AllowTrial();
            }
            else if (kod == "2")
            {
                AllowPro();
            }
            else
            {
                AllowCommon();
            }
        }
    }

}
