using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;
using DataAccess;

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

