using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Oppilaat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet3_Click(object sender, EventArgs e)
    {
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();
    }

    protected void btnGetReal_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["Oppilaat"].ConnectionString;
        //haetaan oppilaat tietokannasta DataTableen
        string message = ""; //this is needed for next function
        try
        {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(cs,"oppilaat", out message);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
            lblMessages.Text = message;
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}