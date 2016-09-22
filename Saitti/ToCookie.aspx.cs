using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ToCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Tarkistetaan löytyykö haluttua keksiä, jos löytyy niin kirjoitetaan sen arvo
        foreach (string keks in Request.Cookies)
        {
            if (keks == "viesti")
                target.InnerHtml = Request.Cookies[keks].Value;
        }
    }
}