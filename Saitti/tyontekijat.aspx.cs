using System;
using System.Data;
using System.Configuration; //Web.config lukemista varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tyontekijat : System.Web.UI.Page
{
    string xmlfile;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Haetaan web.config:ista xml tiedoston nimi
        xmlfile = ConfigurationManager.AppSettings["xmlfile"];
        lblMessages.Text = xmlfile;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //Haetaan XM-data  DataView-olioon, joka kytketään gridView:iin
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfile)); //Huom MapPath muuttaa viittauksen saitin dirikkaan
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();
    }
}