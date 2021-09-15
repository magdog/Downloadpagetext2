using System;


namespace downloadpagetext
{
    class introductoryvalue
    {
        public string ReadFile()
        {

            Console.WriteLine("Введите путь страницы");
            string adres = Console.ReadLine();
            string text = adres;

            return text;
        }
    }
}
