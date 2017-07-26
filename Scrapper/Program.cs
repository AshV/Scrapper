using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = new HtmlDocument();
            document.Load("List.html");
            var bookBoxes = document.DocumentNode.SelectNodes("//*[@class='col-lg-4 col-md-4 col-sm-4 col-xs-12 list-details']");
            //  .Attributes["class"];//.Value.Contains("list-details");
        }
    }
}