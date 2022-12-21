using System;
using System.Xml.Linq;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainRepository objekt = new MainRepository();
            //List<Category> usersREST = objekt.GetCategories();
            //for (int i = 0; i < usersREST.Count; i++)
            //{
            //    Console.WriteLine("ID " + usersREST[i].ID + " NAZIV KATEGORIJE: " +usersREST[i].Description+"URL: "+usersREST[i].Url);
            //}
            String URLString = "http://burzarada.hzz.hr/rss/rsskat1001.xml";
            XDocument xdoc = XDocument.Load(URLString);


            Console.ReadKey();
        }
    }


}

