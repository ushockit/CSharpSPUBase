using ConsoleApp1.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //XDocument doc = new XDocument();

            //XElement root = new XElement("people");

            //XElement elmt = new XElement("person");
            //elmt.Add(new XAttribute("id", "1"));
            //elmt.Add("Vasya");

            //root.Add(elmt);


            //doc.Add(root);
            //doc.Save("people.xml");

            // https://html-agility-pack.net/
            //var doc = new HtmlDocument();
            //doc.Load("phones.xml");

            //var root = doc.DocumentNode;

            //var phonesNode = root.SelectSingleNode("/phones");

            //foreach (var node in phonesNode.ChildNodes)
            //{
            //    if (node.Name.Equals("phone"))
            //    {
            //        Console.WriteLine(node.SelectSingleNode("company").InnerText);
            //        Console.WriteLine(node.SelectSingleNode("price").InnerText);
            //    }
            //}


            //var doc = new HtmlWeb();

            //var docNode = doc.Load("https://www.gismeteo.ua/weather-dnipro-5077/").DocumentNode;

            //// /html/body/section/div[2]/div/div[1]/div/div[2]/div[1]/div[1]/div

            //var node = docNode.SelectSingleNode("/html/body/section/div[2]/div/div[1]/div/div[2]/div[1]/div[1]/div");
            //var minTemp = node.SelectSingleNode("div/div[1]/div[3]/div/div/div/div[1]/span[1]").InnerText;
            //var maxTemp = node.SelectSingleNode("div/div[1]/div[3]/div/div/div/div[1]/span[2]").InnerText;

            //Console.WriteLine(minTemp);
            //Console.WriteLine(maxTemp);


            // Privat24 API https://api.privatbank.ua/#p24/exchangeArchive
            //var client = new RestClient("https://api.privatbank.ua/p24api");

            //var request = new RestRequest("pubinfo?json&exchange&coursid=5", DataFormat.Json);

            //var response = client.Get(request);


            //// https://www.newtonsoft.com/json
            //var courses = JsonConvert.DeserializeObject<List<ExchangeCourseResponse>>(response.Content);
            //BasicConfigurator.Configure();


            LogManager.LoadConfiguration("nlog.config");
            var log = LogManager.GetCurrentClassLogger();

            log.Error("Some error");

            log.Debug("Starting up");
            log.Debug("Shutting down");





            Console.Read();
        }
    }
}
