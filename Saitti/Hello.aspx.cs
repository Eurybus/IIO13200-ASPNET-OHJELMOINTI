﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hello : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Tämä ajetaan sivn latauksen yhteydessä
    }

    protected void btnTervehdi_Click(object sender, EventArgs e)
    {
        //Luetaan käyttäjän antama syöte
        string input = "Terve: " + txtNimi.Text;
        //Esitetään tulos
        lblTulos.Text = input;
    }
}