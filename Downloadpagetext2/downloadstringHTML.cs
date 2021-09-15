using System;
using System.IO;
using System.Net;

namespace downloadpagetext
{
    class downloadstringHTML
    {
        public string Text { get; private set; }

        public downloadstringHTML(string text)
        {
            Text = text;
        }

        public void SaveHTMLPages()
        {

            try
            {
                using (WebClient client = new WebClient()) //здесь объявляется класс WebClient для доступа к его методам он используется для загрузки файлов с определенных ресурсов  
                {
                    string directory = Directory.GetCurrentDirectory(); // Здесь переменной присваивается строка пути к рабочей папке проекта через метод Directory.GetCurrentDirectory(); 
                    Console.WriteLine(Text.ToString());
                    string html = client.DownloadString(Text.ToString());//ToString здесь не нужен так как передаётся переменная в формате string
                    File.WriteAllText(directory + @"\" + ".html", html);
                    Console.WriteLine("File save");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }

        }
    }

}
