using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Web.UI.WebControls;

public partial class RSSfeedit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGetYleFeed_Click(object sender, EventArgs e)
    {
        xdsFeedit.DataFile = @"http://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss"; //@ kertoo, että kenot eivät ole ohjausmerkkejä
        //xdsFeedit.XPath = @"rss/channel/item"; //Tämä on määritelty jo XMLn puolella
        GetFeeds();
    }
    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        //Asetetaan XmlDataSource pointtaamaan Iltasanomien RSS feediin
        xdsFeedit.DataFile = @"http://www.iltasanomat.fi/rss/tuoreimmat.xml"; //@ kertoo, että kenot eivät ole ohjausmerkkejä
        //xdsFeedit.XPath = @"rss/channel/item"; //Tämä on määritelty jo XMLn puolella
        GetFeeds();
    }

    protected void GetFeeds()
    {
        try
        {
            //Hakee xmlDocument-olioon
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc = xdsFeedit.GetXmlDocument();
            XmlNode node1 = xmlDoc.SelectSingleNode("/rss/channel");
            string otsikko = node1["title"].InnerText;
            string jaika = "";//node1["pubDate"].InnerText;
            
            XmlNodeList nodes = xmlDoc.SelectNodes("/rss/channel/item");
            string rsscategory = "";
            string rsstitle = "";
            string rsslink = "";
            HyperLink hl = new HyperLink();

            //Tulos ulos -_-'
            ltMessages.Text = string.Format("<h1>{0}</h1> <h3>{1}</h3>", otsikko, jaika);

            foreach (XmlNode item in nodes)
            {
                //loopitetaan kaikki itemit läpi
                rsstitle = item["title"].InnerText;
                rsslink = item["link"].InnerText;
                rsscategory = item["category"].InnerText;
                hl.Text = Title;
                hl.NavigateUrl = rsslink;
                ltMessages.Text += string.Format("{2}: <a href='{0}'>{1}</a><br>",rsslink,rsstitle,rsscategory);
            }

        }
        catch (Exception ex)
        {
            ltMessages.Text = ex.Message;
        }
    }

    
}