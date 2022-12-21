using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace DataAccess
{
    public class MainRepository
    {
        readonly String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public async Task<List<Category>> GetCategories()
        {
            int ID = 1;
            try {
                string json = await GetRestMethodAsync("http://193.198.242.10/api/2/rest/package/slobodna-radna-mjesta-po-zanimanju");
                List<Category> Kategorije = new List<Category>();
                JObject Json = JObject.Parse(json);
                var oKategorije = Json["resources"].ToList();
                DateTime danas = DateTime.Now;
                for (int i = 0; i < oKategorije.Count; i++)
                {
                    Kategorije.Add(new Category
                    {
                        ID = (int)ID,
                        Description = (string)oKategorije[i]["description"],
                        Url = (string)oKategorije[i]["url"],
                        DatumSpremanjaUBazu = danas
                    });
                    ID++;
                }
                return Kategorije;
            }
            catch
            {
                return null;
            }
        }
        public void DeleteJobFromDB(int idPosla)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM [Kovac_Jobs] WHERE ID = " + idPosla;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void AzurirajKategorijuBP(Category oKategorija)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Kovac_Categories SET Description = '" + oKategorija.Description + "', Url = '" + oKategorija.Url + "', DatumDodavanja = '" + oKategorija.DatumSpremanjaUBazu.ToShortDateString() + "' WHERE Id = " + oKategorija.ID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void AzurirajRadnoMjestoBP(RadnaMjesta oRadnoMjesto)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Kovac_Jobs SET Naziv = '" + oRadnoMjesto.NazivPosao + "', Opis = '" + oRadnoMjesto.OpisPosla + "', Datum = '" + oRadnoMjesto.Datum.ToShortDateString() + "' WHERE Id = " + oRadnoMjesto.IdPosao;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public async Task<List<RadnaMjesta>> GetSvaRadnMjesta()
        {
            List<RadnaMjesta> poslovi = new List<RadnaMjesta>();
            List<Category> kategorije = new List<Category>();
            kategorije = await GetCategories();
            if (kategorije != null)
            {
                foreach (var x in kategorije)
                {
                    poslovi.AddRange(GetRadnaMjestaKategorije(x.Url));
                }
                return poslovi;
            }
            return null;
        }
        public async Task<string> DohvatiUrl(string broj)
        {
            string StringURL = "";
            List<Category> kategorije = new List<Category>();
            kategorije = await GetCategories();
            for (int i = 0; i < kategorije.Count(); i++)
            {
                if (kategorije[i].ID.ToString() == broj)
                {
                    StringURL = kategorije[i].Url;
                }
            }
            return StringURL;
        }
        public List<RadnaMjesta> GetRadnaMjestaKategorije(string URLString)
        {
            XDocument xdoc = XDocument.Load(URLString);
            int ID = 1;
            List<RadnaMjesta> radnMjesta = (from e in xdoc.Root.Elements("channel").Elements("item")
                                            select new RadnaMjesta
                                            {
                                                IdPosao = (int)ID++,
                                                NazivPosao = (string)e.Element("subject"),
                                                Datum = DateTime.ParseExact((string)e.Element("pubDate"), @"dd.MM.yyyy", CultureInfo.InvariantCulture),
                                                OpisPosla = (string)e.Element("description"),
                                                Link = (string)e.Element("link")
                                            }).ToList();
            return radnMjesta;
        }
        public async Task<List<RadnaMjesta>> GetDBFreeJobs()
        {
            var lRadnaMjesta = new List<RadnaMjesta>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM [Kovac_Jobs]";
                connection.Open();
                using (DbDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lRadnaMjesta.Add(new RadnaMjesta()
                        {
                            IdPosao = (int)reader["Id"],
                            NazivPosao = (string)reader["Naziv"],
                            Datum = Convert.ToDateTime((string)reader["Datum"]),
                            OpisPosla = (string)reader["Opis"],
                            Link = (string)reader["Link"]
                        });
                    }
                }
            }
            return lRadnaMjesta;
        }
        public void DeleteCategoryFromDB(int categoryID)
        {

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM [Kovac_Categories] WHERE ID = " + categoryID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void AddJobToDB(RadnaMjesta radnoMjesto)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = $"INSERT INTO [Kovac_Jobs](Naziv,Datum,Opis,Link) VALUES('{radnoMjesto.NazivPosao}','{radnoMjesto.Datum.ToShortDateString()}','{radnoMjesto.OpisPosla}','{radnoMjesto.Link}')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void AddCategory(List<Category> oKategorija)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oConnection.Open();
                foreach (var kategorija in oKategorija)
                {
                    oCommand.CommandText = $"INSERT INTO Kovac_Categories(ID,Description,Url,DatumDodavanja) VALUES('{kategorija.ID}','{kategorija.Description}','{kategorija.Url}','{kategorija.DatumSpremanjaUBazu.ToShortDateString()}')";

                    using (DbDataReader oReader = oCommand.ExecuteReader())
                    {

                    }
                }
                oConnection.Close();
            }
        }
        public async Task<List<Category>> GetDBCategories()
        {
            var lCategories = new List<Category>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Kovac_Categories";
                connection.Open();
                using (DbDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lCategories.Add(new Category()
                        {
                            ID = (int)reader["ID"],
                            Description = (string)reader["Description"],
                            Url = (string)reader["Url"],
                            DatumSpremanjaUBazu = Convert.ToDateTime((string)reader["DatumDodavanja"])
                        });
                    }
                }
            }
            return lCategories;
        }
        public async Task<string> GetRestMethodAsync(string url)
        {
            try
            {
                HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse =  (HttpWebResponse) await webrequest.GetResponseAsync();
                Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
                string result = string.Empty;
                result = await responseStream.ReadToEndAsync();
                webresponse.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Dogodila se greška prilikom poziva na API", ex);
            }
        }
    }
}
