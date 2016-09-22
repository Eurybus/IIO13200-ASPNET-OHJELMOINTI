using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string PublicPropertyMessage
    {
        get { return txtMessage.Text; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Täällä tehdään yleensä kaikki sivun alustukseen liittyvät jutut
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Ping!");
            ddlMessages.Items.Add("Hello, handshake?");
            ddlMessages.Items.Add("Goodbye."); 
        }
    }

    protected void btnQueryString_Click(object sender, EventArgs e)
    {
        //Ohjataan pyyntö uudelle sivulle ja välitetään teksti kutsun mukana
        Response.Redirect("ToQueryString.aspx?Data=" + txtMessage.Text);
    }

    protected void BtnSession_Click(object sender, EventArgs e)
    {
        //Kirjoitetaan sessioon
        Session["viesti"] = txtMessage.Text;
        Response.Redirect("ToSessionState.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        //Luodaan keksi ja kirjoitetaan siihen
        HttpCookie keksi = new HttpCookie("viesti", txtMessage.Text);
        keksi.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(keksi);
        Response.Redirect("ToCookie.aspx");
    }

    protected void btnProperty_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ToPublicProperties.aspx"); //Ei kelpaa tässä tapauksessa
        // koska PreviousPage ei synny
        Server.Transfer("ToPublicProperties.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = ddlMessages.SelectedItem.Text;
    }
}