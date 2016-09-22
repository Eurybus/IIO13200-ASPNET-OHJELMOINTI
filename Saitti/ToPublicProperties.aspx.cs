using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ToPublicProperties : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Tarkistetaan tunnistaako edellisen sivun oikein
        var page = PreviousPage;
        string msg = "";
        if (page != null)
        {
            msg = page.PublicPropertyMessage;
            target.InnerHtml = msg;
        }
        else
        {
            target.InnerHtml = "ei aiempaa sivua";
        }
    }
}