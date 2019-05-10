using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHtmlAsync();
            Console.ReadLine();

            var html = new HtmlDocument();
        }
       private static async void GetHtmlAsync()
        {
            var url = "https://darman.tamin.ir/Forms/Public/Druglist.aspx?pagename=hdpDrugList";
            var httpClient = new HttpClient();
            var html =await httpClient.GetStringAsync(url);            
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var expertsHtml = htmlDocument.DocumentNode.Descendants("select")
            .Where(node => node.GetAttributeValue("id", "")
            .Equals("ctl00_ContentPlaceHolder1_lstspecdesc")).ToList();
            var expertsList = expertsHtml[0].Descendants("option")
                .Where(node => node.GetAttributeValue("value", "")
                .Contains("00")).ToList();
            Console.WriteLine();
            Console.WriteLine(expertsList.First());
        }
    }   
}
