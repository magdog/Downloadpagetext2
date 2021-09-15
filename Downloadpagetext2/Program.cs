using System;

namespace downloadpagetext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте Нажми Enter для старта");
            Console.ReadKey();
            for (; ; )
            {

                Console.WriteLine("Вы хотите выполнить программу?");
                Console.WriteLine("Если да ,то нажмите 1. Если нет ,то нажмите Любую другую кнопку");

                string command = Console.ReadLine();
                try
                {
                    int comman = Convert.ToInt32(command);

                    if (comman == 1) { Start(); }
                    else { break; }
                }
                catch { Console.WriteLine("Спасибо за пользование программой!"); break; }
                Console.WriteLine("Нажми пробел для закрытия программы");
                Console.ReadKey();

            }
        }
        public static void Start()
        {
            introductoryvalue introductoryvalue = new introductoryvalue();
            downloadstringHTML downloadstringHTML;
            parsin parsin;
            var urldata = introductoryvalue.ReadFile();
            Console.WriteLine(urldata);
            downloadstringHTML = new downloadstringHTML(urldata);
            downloadstringHTML.SaveHTMLPages();
            parsin = new parsin(urldata);
            parsin.Work();
        }
    }
}
