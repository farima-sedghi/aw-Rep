using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //string html = await GetHtml();
            //ppp(html);
            //await test();
            await GetHtml();
        }

        private static async Task GetHtml()
        {

            var url = @"https://darman.tamin.ir/Forms/Public/Druglist.aspx?pagename=hdpDrugList";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var nodes = htmlDoc.DocumentNode.SelectNodes("/html/body");

            foreach (var node in nodes)
            {
                Console.WriteLine(node.Attributes["post"].Value);
                Console.ReadLine();
            }
        }

        private static async Task ParseHtml(String html)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var xxx = htmlDoc.DocumentNode
                        .SelectNodes("//body/form///div/table//tr/td/table/tr/td/table/tr/td/table//tr/td/table//tr////td/select/option")
                        ;

            foreach(var node in xxx)
            {
                Console.WriteLine(node.Attributes["value"].Value);
            }
            
        }

        private static async Task ppp(string html)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var xxx = htmlDoc.DocumentNode
                        .SelectNodes("/html")
                        ;

            foreach (var node in xxx)
            {
                Console.WriteLine(node.Attributes["id"].Value);
                Console.ReadLine();
            }
        }

        private static async Task test()
        {
            var html =
        @"<TD class=texte width=""50%"">
			<DIV align=right>Name :<B> </B></DIV>
		</TD>
		<TD width=""50%"">
    		<INPUT class=box value=John maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Tony maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Jams maxLength=16 size=16 name=user_name>
		</TD>
		<TR vAlign=center>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//td/input");

            foreach (var node in htmlNodes)
            {
                Console.WriteLine(node.Attributes["value"].Value);
                Console.ReadLine();
            }
        }
    }
}
